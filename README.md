# Shirt Markdown

Fifth programming exercise in Chapter 2 of textbook.

Not assigned in class, but I'm keeping up my GitHub streak.

This programming exercise contains an error message for an
[unreachable state](https://www.explainxkcd.com/wiki/index.php/2200:_Unreachable_State).

The error message should never be displayed if the algorithm is correct,
since I'm comparing two equivalent expressions.

In other words, given the following:

```
itemMarkdownAmount = itemWholesalePrice * markdownPercentage,
itemMarkdownPrice = itemWholesalePrice * (1 - markdownPercentage);
```
Then this conditional expression should evaluate to `TRUE` for all prices and markdowns:

```
if (itemMarkdownPrice == (itemWholesalePrice - itemMarkdownAmount))
```

Math is fun!

## Example output
```
$ dotnet.exe bin/Debug/netcoreapp2.1/shirt-markdown.dll
Item Name: Open Collar Running Shirt
Wholesale: $41.00
Markdown: $6.15
Sale price: $34.85
```
