# Specification Chains
- A simple example of building And / Or operations into your criteria specifications
- Currently only build for specifying criteria
- Ordering & includes **not** built in
--------
## Example (AND)
```c#
  var isGoodRestaurant = new GoodRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var mySpecification = isGoodRestaurant.And(isAmerican);
```
## Example (OR)
```c#
  var isGoodRestaurant = new GoodRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var mySpecification = isGoodRestaurant.Or(isAmerican);
```
--------
## Example (with Evaluator)
```c#
  var isGoodRestaurant = new GoodRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var mySpecification = isGoodRestaurant.Or(isAmerican);
  var evaluator = new SpecificationEvaluator<Restaurant>();
```
--------
