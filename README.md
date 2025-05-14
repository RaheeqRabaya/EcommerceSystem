E-Commerce System

A simple layered E-Commerce System implemented in C# using .NET 8.0 and Console App.
The system allows customers to view products, add them to a cart, place orders, and process payments with discounts.

Project Structure:
The solution follows the 3-Layer Architecture:

ECommerceSystem
|
├── ECommerceSystem.DataLayer
│   ├── Entities
│   ├── Repository (Impl, Intf)
│   ├── Data
│   └── Enums
|
├── ECommerceSystem.BusinessLayer
│   ├── Managers (Impl, Intf)
│   └── ViewModels
|
└── ECommerceSystem.Presentation
    └── Program.cs

Technologies Used:
- C# (.NET 8.0)
- Console Application
- Object-Oriented Programming
- Layered Architecture
- File-based Data Persistence (JSON)

Key Features:
- Product Management: View, add, and manage product data.
- Shopping Cart: Add/remove products, calculate totals.
- Order Processing: Create orders and apply discounts.
- Payment System: Simulated payment processing.
- OOP Principles:
  - Inheritance (Person -> Customer, Employee)
  - Interfaces (IPayment, IDiscountable)
  - Composition (Order has ShoppingCart)
  - Enums (OrderStatus)
  - Sealed classes (PremiumCustomer)

How to Run:
1. Clone the repository:
   git clone https://github.com/your-username/ECommerceSystem.git

2. Open the solution in Visual Studio 2022 or newer.

3. Set the Startup Project to:
   ECommerceSystem.Presentation

4. Run the application.
