# Sandwich Builder App

## About the Project
This **Sandwich Builder App** lets users make and order their own sandwiches. Customers can enter their details, choose between pickup or delivery, and either pick a pre-made sandwich or create a custom one. The app calculates the total price, including a tip if added, and shows an order receipt.

## Features
- **Enter Customer Info**: Name, phone number, and address.
- **Pickup or Delivery**: Choose how you want to get your sandwich.
- **Choose a Sandwich**:
  - **Pre-Made Sandwich**: Pick from a list with descriptions and images.
  - **Custom Sandwich**: Build your own by selecting ingredients:
    - **Size Options**: Small, Medium, Large, Extra-Large, Party-Size.
    - **Bread Choices**: Italian, Rye, Flatbread, and three more options.
    - **Sauces**: 8+ choices (mayo, mustard, oil, vinegar, etc.).
    - **Meats**: 10+ options (turkey, roast beef, salami, ham, etc.).
    - **Cheeses**: 5+ choices (American, Cheddar, etc.).
    - **Toppings**: 10+ options (lettuce, tomatoes, onions, pickles, etc.).
    - **Extras**: 10+ options (extra cheese, extra meat, bacon, avocado, etc.).
- **Price Calculation**: Based on selected options.
- **Tip Option**: Enter an amount or leave blank.
- **Submit Order**: Redirects to an order confirmation page.

## Class Breakdown
This project has three main classes:

### 1. `Customer` Class
- Stores customer details.
- Properties:
  - Name
  - Phone Number
  - Address
- Methods:
  - Get and set customer details.

### 2. `Sandwich` Class
- Represents a sandwich order.
- Properties:
  - Size
  - Bread Type
  - Selected Sauces
  - Selected Meats
  - Selected Cheeses
  - Selected Toppings
  - Selected Extras
- Methods:
  - Get and set sandwich details.

### 3. `Order` Class
- Manages the order process.
- Properties:
  - Customer Info
  - Sandwich Details
  - Order Date and Time
  - Pickup or Delivery Option
  - Tip Amount
  - Total Cost
- Methods:
  - Store customer details
  - Store sandwich details
  - Calculate total cost
  - Generate receipt

## Order Confirmation Page
- Shows customer details, sandwich selection, and total cost.
- Acts as a digital receipt.

## How to Use
1. Download or clone the project.
2. Open it in Visual Studio. 
3. Run the sandwichbuilde.sln fill out the form, and place an order.

## Possible Future Updates
- Save order history.
- Add user accounts.
- Send email order confirmations.
- Improve UI design.

## Created By
Prantha khan

