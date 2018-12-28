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

