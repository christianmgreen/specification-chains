# Specification Chains
- A simple example of building And / Or operations into your criteria specifications
- Currently only build for specifying criteria
- Ordering & includes **not** built in
--------
## Example (AND)
```c#
  var isGoodRestaurant = new GoodRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var isGoodAndAmerican = isGoodRestaurant.And(isAmerican);
```
## Example (OR)
```c#
  var isItalian = new ItalianRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var isItalianOrAmerican = isItalian.Or(isAmerican);
```
--------
