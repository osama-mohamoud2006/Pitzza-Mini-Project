# Pizza Order Management System

## Overview
The Pizza Order Management System is a Windows Forms application built using C# 7.3 and .NET Framework 4.8.1. It allows users to customize their pizza orders by selecting size, crust type, toppings, and dining preferences. The application dynamically calculates the total price based on the selected options and provides a real-time order summary.

## Features
- **Real-time Price Calculation**: Dynamically updates the total price as the user selects or deselects options.
- **Dynamic Order Summary**: Displays a live summary of the selected size, crust, toppings, and dining location.
- **Order Confirmation**: Prompts the user with a confirmation dialog before finalizing the order.
- **State Management**: Locks the form selections once an order is placed to prevent unintended modifications.
- **Reset Functionality**: Allows resetting the form to its default state for a new order.

## Technical Details

### Price Calculation System
The system relies on the `Tag` property of the RadioButtons and CheckBoxes to store the price of each item. 
- `CalcPriceOfSize()`: Checks which size RadioButton is selected and retrieves its price.
- `CalcPriceOfCurstType()`: Checks which crust RadioButton is selected and retrieves its price.
- `CalcPriceOfToppings()`: Iterates through checked topping CheckBoxes and aggregates their prices.
- `GetTotalPrice()`: Sums the results of the above three methods.
- `UpdatePrice()`: Formats total price into currency layout and updates the UI label.

### UI Update System
The UI summary section updates triggered by `CheckedChanged` events.
- `UpdateSizeLabel(object sender)`: Casts the sender to a RadioButton and updates the Size summary label.
- `UpdateCurstTypeLabel(object sender)`: Casts the sender to a RadioButton and updates the Crust summary label.
- `UpdateToopingsLabel()`: Iterates through the selected toppings and concatenates their text into a comma-separated string to display in the Toppings summary label.
- `UpdateEatStatusLabel(object sender, EventArgs e)`: Updates whether the order is for dine-in or take-out.

### State Management
- `SetAllControlsToDefaultValues()`: Sets the default pizza configuration (Small, Thin Crust, Eat-In, no extra toppings).
- `DisableGroups()` / `EnableGroups()`: Toggles the `Enabled` state of the GroupBoxes (Size, Crust, Toppings, WhereToEat) to lock or unlock user inputs.

### Event Handling
- **Form Load**: Initializes default configurations via `SetAllControlsToDefaultValues()`.
- **CheckedChanged Events**: Every time a selection changes, it triggers the corresponding summary update method and recalculates the total price.
- **btnOrderPizza_Click**: Shows a confirmation dialog. If confirmed, UI groups are disabled, order confirmation is shown, and the reset button is enabled.
- **btnResetForm_Click**: Confirms resetting of the form. If confirmed, UI groups are re-enabled, selections are reset to default, and the order button is re-enabled.

## Prerequisites
- .NET Framework 4.8.1
- Visual Studio (or any compatible C# IDE supporting Windows Forms)

## Usage
1. Build and run the solution.
2. Select your desired pizza size, crust type, and add custom toppings.
3. Select whether the order is "Eat In" or "Take Out".
4. Review the auto-generated total price and order summary.
5. Click "Order Pizza" to confirm and lock the order.
6. Click "Reset Form" to start a new order.
