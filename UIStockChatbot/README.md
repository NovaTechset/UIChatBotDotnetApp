# UIChatBotDotnetApp
### Stock Exchange Chatbot - README

This README provides instructions on how to set up and run the Stock Exchange Chatbot application. The chatbot is built using C#.NET MVC with jQuery AJAX for dynamic content loading.

### Setup Instructions

#### Prerequisites
1. **Visual Studio**: Ensure you have Visual Studio installed with ASP.NET MVC support.
2. **.NET Framework**: The project uses .NET Framework. Ensure you have the appropriate version installed.

#### Steps to Setup
1. **Clone the Repository**: Clone this repository to your local machine using Git.
   ```bash
   git clone git clone https://github.com/NovaTechset/UIChatBotDotnetApp.git
   ```
   
2. **Open Project in Visual Studio**:
   - Navigate to the cloned directory and open the solution file (`UIStockChatbot.sln`) in Visual Studio.

3. **Build the Solution**: Build the solution to restore packages and ensure everything compiles correctly.

4. **Set Startup Project**:
   - Set the startup project to `UIStockChatbot`.

5. **Run the Application**:
   - Press `Ctrl + F5` or use the Debug menu to start the application without debugging.
   - This will launch the application in your default web browser.

### Accessing the Application

Once the application is running, you can access it by navigating to the provided URL, typically `http://localhost:{port}/`.

### Application Overview

#### Functionality
- **Home Menu**: Presents three options for selecting a stock exchange (LSEG, NASDAQ, NYSE).
- **Stock Menu**: Upon selecting an exchange, displays five stocks traded in that exchange.
- **Stock Price View**: After selecting a stock, shows the current price and allows navigation back to the Stock Menu or Home Menu.

#### Technologies Used
- **C#**: Backend logic and MVC framework.
- **ASP.NET MVC**: Structure for web application.
- **jQuery AJAX**: Dynamically loads stock data without page refresh.
- **JSON**: Data storage and retrieval from `Chatbot-stockdata.json`.

### Additional Notes

- **JSON Data**: The application loads stock data from `Chatbot-stockdata.json`, located in the `App_Data` folder. Ensure this file exists and contains valid JSON data as per the provided format.
- **Error Handling**: Basic error handling is implemented for file read errors and JSON parsing failures.
- **Optimizations**: The application could be further optimized for performance and scalability based on specific deployment needs.