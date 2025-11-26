# cafe-management-system-csharp
cafe shop management system bernama "SOLUNE"
## Fitur Utama

-  Login & autentikasi user
-  Manajemen menu
-  Manajemen inventaris
-  Sistem POS (Point of Sale)
-  Riwayat & laporan penjualan
-  Manajemen pengguna
-  Pengaturan sistem
## Teknologi yang Digunakan

- C# (.NET / WinForms / WPF)
- SQL Server Management Studio (SSMS)
- Visual Studio 2022
  
## Struktur Folder

```
SOLUNE/
├── SOLUNE.UI/        # UI (WinForms/WPF)
├── SOLUNE.Business/  # Business Logic
├── SOLUNE.Data/      # Data Access (ADO.NET)
├── SOLUNE.Models/    # Data Models
└── SQL/              # Database Script
```
## Struktur Database

```
Users
Menu
Category
Orders
OrderDetails
Inventory
SalesReport
```



## Struktur Navigasi SOLUN

```
SOLUNE System
├── LoginPage
├── Dashboard
│   ├── MenuManagement
│   ├── InventoryManagement
│   ├── TransactionPOS
│   └── SalesReport
├── Settings
│   └── UserManagement
└── Logout
```
