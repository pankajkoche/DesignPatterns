
/*  logging service in a .NET application. We can use the Singleton pattern to ensure that there's a single
 *  instance of the logging service throughout the application's lifetime, providing a centralized point for logging messages. */

using Singleton;

Logger logger = Logger.Instance;

// Use the logger to log messages.
logger.Log("Application started.");
logger.Log("Performing some operation.");
logger.Log("Operation completed.");


var anotherComponent = new AnotherComponent();
anotherComponent.DoSomething();