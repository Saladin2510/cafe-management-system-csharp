# cafe-management-system-csharp
![Static Badge](https://img.shields.io/badge/Visual%20Studio%202022-purple)
![Static Badge](https://img.shields.io/badge/SSMS-yellow)
![Static Badge](https://img.shields.io/badge/CSharp-blue)

cafe shop management system bernama "SOLUNE"
## Fitur Utama

-  Login & autentikasi user
-  Manajemen menu
-  Manajemen inventaris
-  Riwayat & laporan penjualan
## Teknologi yang Digunakan

- C# (.NET / WinForms / WPF)
- SQL Server Management Studio (SSMS)
- Visual Studio 2022
  
## Struktur Folder

```
SOLUNE/
├── Form1.cs/                # Login Form 
├── RegisterForm.cs/         # Register Form
├── CashierMainForm/         # Cashier Dashboard
├── AdminMainForm/           # Admin Dashboard
├── CashierOrderForm.cs/     # Cashier Order Form
├── CashierCustomerForm.cs/  # Cashier Order Form
├── AdminAddProducts.cs/     # Admin Add Product
└── AdminAddUsers.cs/        # Admin Add Users
```
## Struktur Database

```
Users
Products
Orders
Customers
```



## Struktur Navigasi SOLUNE

```
SOLUNE System
├── LoginPage
├── Dashboard (Admin)
│   ├── Add Cashier
│   ├── Add Products
│   └── Customers
├── Dashboard (Cashier)
│   ├── Add Products
│   ├── Order
│   └── Customers
└── Logout
```
