# Calorie Calculator Application

## Overview

This is a desktop application written in C# that allows users to track their calorie intake and manage their nutrition. It provides features such as logging food, viewing calorie history, updating profile information, and more.

## System Requirements

To run the Calorie Calculator Application, ensure that your system meets the following requirements:

- **Operating System**: Windows 7 or later
- **.NET Framework**: .NET Framework 4.7.2 or later
- **SQLite Package**: Required for database management
- **SQLIDE Extension**: Recommended for database management and visualization
- **Newtonsoft.Json**: Required for JSON serialization and deserialization

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/your-username/calorie-calculator.git
   ```

2. Open the solution file (`CalorieCalculator.sln`) in Visual Studio.

3. Register at [Api-ninjas](https://api-ninjas.com/) and insert your API key in the ParserManager.cs file

3. Build the solution to restore packages and compile the application.

4. Run the application by pressing F5 or clicking the "Start" button in Visual Studio.

## Usage

- Upon running the application, you will be prompted to log in or register if it's your first time using it.
- Once logged in, you can log food items, view your calorie history, update your profile information, and more.


## Contributing

Contributions are welcome! If you'd like to contribute to the project, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature/your-feature-name`).
6. Create a new Pull Request.

## This project can be extended with:

1. **View Personal User Data**: Extend the application to display additional user information such as first name, last name, and other profile details.

2. **View Macro-Nutrients History**: Enhance the calorie history feature to include the tracking of macronutrients (carbohydrates, proteins, fats) either overall or on a per-day basis.

3. **Change Serving Size Upon Logging the Food**: Implement functionality to allow users to customize the serving size of food items when logging them into the system.

4. **Allow Edit of Logged Food**: Enable users to edit or delete previously logged food entries, providing greater flexibility in managing their dietary records.

