# Hair Salon Pricing Application

## Description
This Windows Forms Application calculates and displays pricing for a hair salon, allowing the user to select a hairdresser and one or more services. The application includes features like user input validation, dynamic UI updates, and total cost calculation. It follows a clean and intuitive GUI layout to ensure a user-friendly experience.

---

## Features
### User Interface
- **Hairdresser Selection**:
  - A **ComboBox** (DropDownList style) allows the user to select one hairdresser, each with a different base rate:
    - Jane - $30
    - Pat - $45
    - Ron - $40
    - Sue - $50
    - Laurie - $55

- **Service Selection**:
  - A **ListBox** lets the user select one or more services, each with a specific rate:
    - Cut - $30
    - Wash, blow-dry, and style - $20
    - Colour - $40
    - Highlights - $50
    - Extension - $200
    - Up-do - $60

- **Charged Items and Prices**:
  - Selected hairdresser and services are displayed in a **Charged Items ListBox**.
  - Corresponding prices are displayed in a **Price ListBox**.

- **Buttons**:
  - **Add Service Button**:
    - Adds the selected hairdresser (first use only) and selected services to the Charged Items ListBox.
    - Updates the Price ListBox with corresponding prices.
  - **Calculate Total Price Button**:
    - Displays the total cost of all items in the Price ListBox in currency format.
  - **Reset Button**:
    - Resets all selections and UI components to their initial state.

### Input Validation
- **Button State Management**:
  - The **Add Service Button** is disabled until at least one service is selected from the ListBox.
  - The **Calculate Total Price Button** is disabled until the **Add Service Button** has been clicked.
  - The **Hairdresser ComboBox** is disabled after the **Add Service Button** is clicked for the first time.

### Reset Functionality
- Resets the application to its default state:
  - Selects the first hairdresser in the ComboBox.
  - Clears the Charged Items ListBox and Price ListBox.
  - Clears the Total Price Label.
  - Disables the **Add Service** and **Calculate Total Price** Buttons.
  - Focuses on the **Hairdresser ComboBox**.
## How to Use
1. **Start the Application**:
   - The **Hairdresser ComboBox** is enabled by default.
   - The **Add Service** and **Calculate Total Price** Buttons are disabled.

2. **Select a Hairdresser**:
   - Choose one hairdresser from the ComboBox.

3. **Select Services**:
   - Choose one or more services from the ListBox.

4. **Click "Add Service"**:
   - Adds the hairdresser (on the first click) and selected services to the Charged Items ListBox.
   - Updates the Price ListBox with the corresponding prices.

5. **Click "Calculate Total Price"**:
   - Displays the total cost of all selected items in the Total Price Label.

6. **Click "Reset"**:
   - Resets the application to its initial state.

## Requirements
- **.NET Framework**: Compatible with Windows Forms.
- **IDE**: Visual Studio (recommended).
