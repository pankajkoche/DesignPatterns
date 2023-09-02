
using Prototype;

// Create an initial WelcomeEmail template
IEmailTemplatePrototype welcomeTemplate = new WelcomeEmail();

// Clone the welcome template and customize it
IEmailTemplatePrototype personalizedWelcome = welcomeTemplate.Clone();
personalizedWelcome.Customize("Alice");
personalizedWelcome.Render();
// Create and customize an order confirmation email
IEmailTemplatePrototype orderConfirmationTemplate = new OrderConfirmationEmail();
orderConfirmationTemplate.Customize("Bob");
orderConfirmationTemplate.Render();