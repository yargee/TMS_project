using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Utility.IDChecker;

namespace Utility.Data
{
    internal class StandartSofaPattern : IParsingPattern
    {
        private UtilityDbContext _context;
        private TextBox _textBox1;
        private TextBox _textBox2;
        private TextBox _textBox3;

        public StandartSofaPattern(UtilityDbContext context, TextBox tb1, TextBox tb2, TextBox tb3)
        {
            _context = context;
            _textBox1 = tb1;
            _textBox2 = tb2;
            _textBox3 = tb3;
        }

        public void Parse()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы Excel|*.xlsx;*.xls";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                using (var workbook = new XLWorkbook(selectedFilePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed();
                    var columns = worksheet.ColumnsUsed();
                    var equalizer = new StringEqualizer();

                    _textBox3.Clear();

                    for (int i = 1; i <= rows.Count(); i++)
                    {
                        for (int j = 1; j <= columns.Count(); j++)
                        {
                            var stringValue = equalizer.ReplaceEnglishLetters(worksheet.Cell(i, j).Value.ToString());

                            if (!IsTargetRow(stringValue, out string name))
                            {
                                _textBox2.AppendText("строка выхода из цикла " + i + " " + name + Environment.NewLine);
                                break;
                            }

                            if (TryFindCollection(stringValue, out FurnitureCollection collection))
                            {
                                var elementData = new StringBuilder();
                                elementData.Append(collection.CollectionId + ";" /*артикул коллекции*/
                                                 + worksheet.Cell(i, j - 1).Value.ToString() + ";"  /*имя элемента*/
                                                 + worksheet.Cell(i, j).Value.ToString() + ";"); /*артикул элемента*/

                                string collectionId = "";
                                string elementId = "";
                                string elementName = "";

                                List<ElementPrice> prices = new();

                                for (int k = j + 1; k <= columns.Count(); k++)
                                {
                                    if (worksheet.Cell(i, k).Value.IsNumber)
                                    {
                                        elementData.Append((int)worksheet.Cell(i, k).Value + ";");
                                    }
                                }

                                _textBox3.AppendText("data " + elementData.ToString() + Environment.NewLine);
                                var data = elementData.ToString().Split(';');

                                for (int n = 0; n < data.Length-1; n++)
                                {
                                    switch (n)
                                    {
                                        case 0:
                                            collectionId = data[n];
                                            break;
                                        case 1:
                                            elementName = data[n];
                                            break;
                                        case 2:
                                            elementId = data[n];
                                            break;
                                        default:
                                            {
                                                int.TryParse(data[n], out int price);
                                                prices.Add(new ElementPrice(elementId, n, price));
                                            }
                                            break;
                                    }
                                }

                                var element = new FurnitureElement(collectionId, elementId, elementName);

                                foreach (var price in prices)
                                {
                                    element.Prices.Add(price);
                                }

                                _context.Add(element);
                                _context.SaveChanges();

                                i++;
                                j = 0;
                                _textBox1.AppendText(collectionId + "//" + elementId + Environment.NewLine);
                                elementData = null;
                            }
                        }
                    }
                }
            }
        }

        private bool TryFindCollection(string s, out FurnitureCollection collection)
        {
            collection = _context.Collections.FirstOrDefault(x => (s.Contains(x.CollectionId) || s.Equals(x.CollectionId)));

            return collection != null ? true : false;

        }

        private bool IsTargetRow(string s, out string name)
        {
            var strings = s.Split(' ');

            foreach (var unit in strings)
            {
                var collection = _context.Collections.FirstOrDefault(x => unit.Equals(x.Name));

                if (collection != null)
                {
                    name = collection.Name;
                    return false;
                }
            }

            name = "no collections";

            return true;
        }
    }
}
