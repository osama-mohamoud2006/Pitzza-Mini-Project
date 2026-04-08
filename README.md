# Pitzza Mini Project

A C# Windows Forms desktop application for building and ordering a pizza, implemented in **two versions** inside one repository:

- **Root version (original):** first implementation with direct event-driven mutable state logic.
- **Refactored version:** cleaner implementation with separated calculation/update methods and better UI defaults.

---

## Table of Contents

1. [Project Goal](#project-goal)
2. [Repository Layout](#repository-layout)
3. [Technology Stack](#technology-stack)
4. [Feature Set](#feature-set)
5. [How the App Works](#how-the-app-works)
6. [Root Version (Original)](#root-version-original)
7. [Refactored Version](#refactored-version)
8. [Detailed Difference: Root vs Refactored](#detailed-difference-root-vs-refactored)
   1. [State management strategy](#1-state-management-strategy)
   2. [Pricing source](#2-pricing-source)
   3. [Method decomposition](#3-method-decomposition)
   4. [UX defaults](#4-ux-defaults)
   5. [Summary rendering](#5-summary-rendering)
   6. [Complexity and extensibility](#6-complexity-and-extensibility)

---

## Project Goal

This project demonstrates a complete pizza-ordering flow in WinForms:

- choose pizza size
- choose crust type
- select toppings
- choose dine mode (Eat In / Take Out)
- observe real-time order summary
- observe real-time total price
- place order with confirmation
- reset form for a new order

It also demonstrates software evolution: **from an initial working version** to a **refactored, cleaner version**.

---

## Repository Layout

### Root (Original version)
- `Program.cs`  
- `Form1.cs` (class: `frmMain`)  
- `Form1.Designer.cs`  
- `Form1.resx`  
- `Pizzza.csproj`  

### Refactored version
- `Pizza Project Refactored/Program.cs`  
- `Pizza Project Refactored/Form1.cs` (class: `Form1`)  
- `Pizza Project Refactored/Form1.Designer.cs`  
- `Pizza Project Refactored/Form1.resx`  
- `Pizza Project Refactored/Pizza Project Refactored.csproj`  

### Other repository content
- assets (e.g., `pizza.ico`, `pizzaBC.jpg`)
- build/IDE artifacts present in repository (`.vs`, `bin`, `obj`)

---

## Technology Stack

- **Language:** C#
- **Framework/UI:** .NET Windows Forms (`System.Windows.Forms`)
- **Application Type:** Desktop GUI
- **Programming Model:** Event-driven UI programming
- **Project config:** `.csproj`
- **Solution metadata:** `.slnx`
- **Resources:** `.resx`, image/icon files

---

## Feature Set

Implemented in both versions (with different internal designs):

1. **Pizza Size Selection**  
   - Single-select radio buttons
2. **Crust Type Selection**  
   - Single-select radio buttons
3. **Toppings Selection**  
   - Multi-select checkboxes
4. **Where To Eat Selection**  
   - Eat In / Take Out
5. **Order Summary Panel**  
   - selected size
   - selected crust
   - selected toppings
   - where to eat
   - total price
6. **Order Confirmation Flow**
7. **Reset/New Order Flow**
8. **Live price updates on interaction**

---

## How the App Works

### High-level execution flow
1. `Program.Main()` starts WinForms and opens main form.
2. Form `Load` event initializes defaults and/or pricing metadata.
3. User interactions fire events (`CheckedChanged`, `Click`).
4. Handlers update:
   - summary labels
   - total price
   - form enabled/disabled state
5. Order or reset triggers modal confirmations.

---

## Root Version (Original)

<img width="1397" height="574" alt="image" src="https://github.com/user-attachments/assets/518cdb3e-69ac-4a3d-a017-0a7cc2bffbf4" />

### Entry and form class
- `Program.cs` launches `frmMain`.
- Main logic lives inside `Form1.cs` (`frmMain : Form`).

### State model
The original version uses mutable internal state:

- `_TotalPrice` (running accumulator)
- `TheLastRbOfSize` and `TheLastRbOfCurstType` to remove previous radio price before adding current one
- struct `stDataForEachTag` (`name`, `price`) stored in control `Tag`

### Pricing setup
Instead of static designer tags, original code assigns values at runtime through two methods:

- `AssignTagsValuesForRadioButtons()`
- `AssignTagsValuesForCheckBoxes()`

This uses arrays and loops to assign `Tag` objects to controls.

### Price update logic
- **Size radio change:**  
  subtract old selected size price, add current selected size price
- **Crust radio change:**  
  subtract old selected crust price, add current selected crust price
- **Toppings checkbox change:**  
  add/remove topping price directly from `_TotalPrice`
- `UpdatePriceLabel()` writes rounded/ceiled value to UI

### Summary logic
- size summary from selected size radio text
- crust summary from selected crust radio text
- toppings summary built by iterating all topping checkboxes and concatenating selected text
- where-to-eat summary updated from eat mode radio text

### Order and reset behavior
- `btnOrder_Click`:
  - asks confirmation
  - disables selection groups
  - shows success message
- `btnRest_Click`:
  - asks confirmation
  - unchecks all options
  - clears summary
  - resets internal tracking references
  - re-enables controls

### Characteristics
- Works, but has heavier branching and manual state management.
- More error-prone over time when adding features.

---

## Refactored Version 

<img width="1142" height="602" alt="image" src="https://github.com/user-attachments/assets/62510ab1-14c5-45da-ac2c-9ef1dc3dbde1" />

### Entry and form class
- `Program.cs` launches `Form1`.
- Main behavior in `Pizza Project Refactored/Form1.cs`.

### Structural improvements
The refactored code separates responsibilities into focused methods:

- calculation methods
- summary update methods
- control-state methods (enable/disable/default)

### Price calculation design
Refactored design computes totals from current UI state (stateless recalculation):

- `CalcPriceOfSize()`
- `CalcPriceOfCurstType()`
- `CalcPriceOfToppings()`
- `GetTotalPrice()` = sum of all groups
- `UpdatePrice()` updates label

This avoids fragile “subtract previous selection” logic.

### Event organization
- `Size_CheckedChanged` => update size summary + update total
- `Crust_CheckedChanged` => update crust summary + update total
- `Topping_CheckedChanged` => update toppings summary + update total
- `UpdateEatStatusLabel` => updates eat mode label

### Defaults and UX
On load, `SetAllControlsToDefaultValues()` sets:
- Eat In selected
- Small selected
- Thin crust selected
- all toppings unchecked

So app starts in a valid order state with predictable behavior.

### Order/reset flow
- `btnOrderPizza_Click`
  - confirm dialog
  - disable groups
  - disable order button
  - show confirmation
  - enable reset button
- `btnResetForm_Click`
  - confirm dialog
  - enable groups
  - restore default selections
  - re-enable order button

### Characteristics
- Clearer method boundaries
- Easier to test/maintain
- Better readability

---

## Detailed Difference: Root vs Refactored

## 1) State management strategy
- **Root:** incremental mutable accumulator (`_TotalPrice`) + “last selected radio” trackers
- **Refactored:** recompute from current form state each update

**Why it matters:** recomputation is safer and less bug-prone.

---

## 2) Pricing source
- **Root:** prices assigned in code during initialization via arrays + struct in `Tag`
- **Refactored:** prices mostly embedded as control `Tag` values in designer

**Tradeoff:**  
- root gives central runtime assignment logic  
- refactored gives simpler direct UI mapping  
- best next step: move both to domain/config constants

---

## 3) Method decomposition
- **Root:** larger multi-purpose handlers, helper methods mixed with state mutation
- **Refactored:** narrow methods with single responsibility (calculate/update/enable/reset)

**Impact:** refactored is easier for onboarding and feature extension.

---

## 4) UX defaults
- **Root:** starts with mostly blank/unchecked and disabled ordering behavior until user action
- **Refactored:** starts with valid defaults and immediate visible price flow

**Impact:** better user experience and fewer edge interactions.

---

## 5) Summary rendering
- **Root:** toppings summary built with multiline entries
- **Refactored:** toppings summary built with comma-separated single line text


---

## 6) Complexity and extensibility
- **Root:** adding coupons/tax/fees risks touching many interconnected handlers
- **Refactored:** easier to insert extra logic in `GetTotalPrice()` pipeline

---


