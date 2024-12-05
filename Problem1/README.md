
# Multiplication Table Program in C#

This C# program generates and displays a neatly formatted multiplication table from 1 to 10. The table includes both a header row and values organized in rows and columns, separated for readability.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem1`
- **Class**: `Problem1`
  - The class is marked as `internal`, meaning it is accessible only within the same assembly.

### Main Components
1. **`PrintTableHeader` Method**:
   - Outputs the header for the multiplication table.
   - Prints numbers from 1 to 10 as column headers.
   - Adds a horizontal separator line for better table formatting.

2. **`ColumnSeparator` Method**:
   - Determines the appropriate column separator to align values properly.
   - Returns `"   |"` for single-digit row numbers and `"  |"` for double-digit row numbers to maintain consistent spacing.

3. **`PrintMultiplicationTable` Method**:
   - Combines the header and the table rows to display the entire multiplication table.
   - Uses nested loops:
     - Outer loop: Iterates through the row numbers (1 to 10).
     - Inner loop: Iterates through the column numbers (1 to 10) and calculates the product of the row and column indices.
   - Calls `ColumnSeparator` to format the output.

4. **`Main` Method**:
   - The program entry point.
   - Calls the `PrintMultiplicationTable` method to display the table.

---

## How It Works

1. **Table Header**:
   - Displays the title: `"Multiplication Table From 1 to 10"`.
   - Prints numbers 1 to 10 as the top row.
   - Adds a horizontal line separator.

2. **Table Rows**:
   - Each row starts with the row number and a separator (`|`).
   - Columns in each row represent the product of the row number and column index.

3. **Formatted Output**:
   - Consistent spacing ensures values align correctly in columns for easy readability.

---

## Sample Output

```plaintext

                        Multiplication Table From 1 to 10

        1       2       3       4       5       6       7       8       9       10
ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
 1   |       1       2       3       4       5       6       7       8       9      10
 2   |       2       4       6       8      10      12      14      16      18      20
 3   |       3       6       9      12      15      18      21      24      27      30
 4   |       4       8      12      16      20      24      28      32      36      40
 5   |       5      10      15      20      25      30      35      40      45      50
 6   |       6      12      18      24      30      36      42      48      54      60
 7   |       7      14      21      28      35      42      49      56      63      70
 8   |       8      16      24      32      40      48      56      64      72      80
 9   |       9      18      27      36      45      54      63      72      81      90
10   |      10      20      30      40      50      60      70      80      90     100
