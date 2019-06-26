# Specification Chains
- A simple example of building And / Or operations into your criteria specifications
-----
## Usage
```c#
  var isGoodRestaurant = new GoodRestaurantSpecification();
  var isAmerican = new AmericanRestaurantSpecification();

  var evaluator = new SpecificationEvaluator<Restaurant>();
  var mySpecification = isGoodRestaurant.And(isAmerican);
```
---
