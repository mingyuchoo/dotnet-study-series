open System
open System.IO
open OfficeOpenXml


let processExcelFile inputFilePath outputFilePath =
    let inputFile = new FileInfo(inputFilePath)
    let outputFile = new FileInfo(outputFilePath)

    use package = new ExcelPackage(inputFile)
    // Get the first worksheet
    let worksheet = package.Workbook.Worksheets.[0]

    // Add a third column for the sums
    worksheet.Cells.[1, 3].Value <- "y"

    // Iterate through the rows and add the values
    let rowCount = worksheet.Dimension.Rows
    for row in 2 .. rowCount do
        let firstColumnValue = Convert.ToDouble(worksheet.Cells.[row, 1].Value)
        let secondColumnValue = Convert.ToDouble(worksheet.Cells.[row, 2].Value)
        worksheet.Cells.[row, 3].Value <- firstColumnValue + secondColumnValue

    // Save the worksheet to the output file
    package.SaveAs(outputFile)

    printfn "Output file created successfully."


[<EntryPoint>]
let main argv =
    let inputFilePath = "input.xlsx"
    let outputFilePath = "output.xlsx"
    processExcelFile inputFilePath outputFilePath
    0