# Goldfish Corporation Bicycle Order Application

A classic .NET Framework 4.7.2 Windows Forms application designed for a bicycle retailer ("Goldfish Corporation") where customers can browse premium bicycles, customize their orders, apply promotional discounts, and complete a simulated checkout and payment process. The application also includes an administrative dashboard with interactive charts displaying sales performance metrics.

## 🚲 Features

- **User Authentication**:
  - Guest access or account registration.
  - Interactive login validation (e.g. email/password constraints).
- **Interactive Catalog**:
  - Detailed profiles, reviews, and descriptions for premium road and mountain bikes (such as the *Atlas Ultegra Mechanical Disc*, *Eros Dura Ace D12 Enve*, and *Arktos 29 ST GX Eagle*).
  - High-quality product images and visual rating systems.
- **Customized Ordering**:
  - Ability to choose bike frame sizes (52cm, 54cm, 56cm, 58cm, 61cm).
  - Optional accessory add-ons: JBL Portable Bluetooth Speaker, Fly 12 CE Front Camera, and Wahoo RPM Speed/Cadence Sensor.
  - Optional warranty packages: Basic, Exterior, and Crash Replacement.
- **Dynamic Pricing & Promotions**:
  - Live order summary updating cumulative and discounted totals.
  - Special promotional discount codes:
    - `cnyHuat` - exclusive gifts (Goldfish Red Packets).
    - `onlineFive` - 5% discount (requires minimum spend of $6,500).
    - `rideSafe` - free mountain bike helmet.
- **Comprehensive Checkout Flow**:
  - Choose collection/delivery options: Self-collection (with outlet selection), Home Delivery (with address and postal validation), or Reservation (with date/time booking).
  - Integrated payment page simulating Visa/MasterCard card number checking.
- **Sales Analytics Dashboard**:
  - Password-protected administrator view (`goldfishcorp123`).
  - Interactive bar charts (`System.Windows.Forms.DataVisualization.Charting`) detailing sales volume of different bike models, add-on accessories, and warranty tiers, alongside total accumulated EOD sales.

## 🛠️ Technology Stack

- **Frontend/UI**: Windows Forms (WinForms) with legacy Visual Basic PowerPacks for custom shape rendering.
- **Backend Logic**: C# (.NET Framework 4.7.2).
- **Graphics & Visuals**: GDI+ and MS Chart Controls.

## 🚀 Setup and Compilation

### Prerequisites
- Windows OS (required for Windows Forms / .NET Framework execution).
- **Visual Studio 2022** (with *.NET Desktop Development* workload enabled) or **MSBuild**.

### Build Instructions
1. Clone the repository to your local system:
   ```bash
   git clone https://github.com/your-username/goldfish-corporation-bicycle-order.git
   ```
2. Open the solution file `Goldfish Corporation Bicycle Order Application.sln` in Visual Studio 2022.
3. Build the solution (Ctrl + Shift + B) to compile all binaries.
4. Run the project (F5) to start the application.
