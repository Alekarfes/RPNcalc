# RPNcalc
A calculator built in C# that translates mathematical expression into RPN (reverse polish notation) and calculates it during translation

## Examples
```csharp
RPNcalc calc = new RPNcalc();
calc.Calculate("700+(2-4/2+(6))*2");
MessageBox.Show(calc.Result);
```
```csharp
RPNcalc calc = new RPNcalc();
calc.Calculate("414 / ( 55 - 27 / 3 )");
MessageBox.Show(calc.RPN);
```

Right now this calculator can add, subtract, divide, multiply and process brackets. 
You can add any operations you want in section of RPN.cs marked with "symbol priority checking", but make sure their priority is correct.

Current priorities:```
high: * /
low: + −
the lowest: ( )
```
