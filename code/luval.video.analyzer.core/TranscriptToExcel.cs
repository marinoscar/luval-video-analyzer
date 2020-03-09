using luval.video.analyzer.core.Entities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core
{
    public class TranscriptToExcel
    {
        public static void SaveTranscript(string fileName, Video video)
        {
            using (var package = new ExcelPackage(new FileInfo(fileName)))
            {
                using (var workbook = package.Workbook)
                {
                    using (var sheet = workbook.Worksheets.Add("Transcript"))
                    {
                        sheet.Cells[1, 1].Value = "Id";
                        sheet.Cells[1, 2].Value = "Start";
                        sheet.Cells[1, 3].Value = "End";
                        sheet.Cells[1, 4].Value = "Text";
                        var row = 2;
                        foreach (var tran in video.Insights.Transcript)
                        {
                            var ins = tran.Instances.FirstOrDefault() ?? new TranscriptInstance();
                            sheet.Cells[row, 1].Value = tran.Id;
                            sheet.Cells[row, 2].Value = ins.Start;
                            sheet.Cells[row, 3].Value = ins.End;
                            sheet.Cells[row, 4].Value = tran.Text;
                            row++;
                        }
                        sheet.Tables.Add(sheet.Cells[1, 1, row, 4], "TranscriptData");
                        package.Save();
                    }
                }
            }
        }
    }
}
