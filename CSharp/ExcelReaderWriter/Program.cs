using System;
using System.Data;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        // Load the input.xlsx file
        FileInfo inputFile = new FileInfo("input.xlsx");
        FileInfo outputFile = new FileInfo("output.xlsx");

        using (ExcelPackage package = new ExcelPackage(inputFile))
        {
            // Get the first worksheet
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            // Add a third column for the sums
            worksheet.Cells[1, 3].Value = "y";

            // Iterate through the rows and add the values
            int rowCount = worksheet.Dimension.Rows;
            for (int row = 2; row <= rowCount; row++)
            {
                double firstColumnValue = Convert.ToDouble(worksheet.Cells[row, 1].Value);
                double secondColumnValue = Convert.ToDouble(worksheet.Cells[row, 2].Value);
                worksheet.Cells[row, 3].Value = firstColumnValue + secondColumnValue;
            }

            // Save the worksheet to the output file
            package.SaveAs(outputFile);
        }

        Console.WriteLine("Output file created successfully.");
    }
}