
using Factory;

//In this example, we're building a simple report generation application that can generate reports in different formats, such as PDF and CSV
//. The Factory Method Pattern is used to create reports without knowing their exact types, promoting flexibility and scalability in the application.


// STEP 1
// define an interface IReport that declares the common method Generate(). This interface represents the common behavior that all report types should have.


// STEP 2
//We create two concrete classes, PdfReport and CsvReport, both of which implement the IReport interface.
//Each concrete product represents a specific type of report (PDF or CSV) and provides its own implementation of the Generate() method,
//which includes logic for generating that type of report.

// STEP 3
//We create an abstract class called ReportFactory, which serves as the creator.
//This abstract class declares an abstract factory method CreateReport() that returns an instance of IReport.

// STEP 4
//create two concrete creator classes, PdfReportFactory and CsvReportFactory, each of which inherits from the ReportFactory abstract class.
//Each concrete creator class provides an implementation of the factory method CreateReport() specific to the type of report it should create.





// create instances of PdfReportFactory and CsvReportFactory, and then use their CreateReport() methods to create reports.
//Finally, we call the Generate() method on each report, which is polymorphically executed based on the actual type of the report shown in bellow

ReportFactory pdfFactory = new PdfReportFactory();
ReportFactory csvFactory = new CsvReportFactory();

IReport pdfReport = pdfFactory.CreateReport();
IReport csvReport = csvFactory.CreateReport();  

pdfReport.Generate();
csvReport.Generate();