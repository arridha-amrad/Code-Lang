<?php

declare(strict_types=1);

class Product
{
  public string $name;
  public float $price;

  function __construct(string $name, float $price)
  {
    $this->name = $name;
    $this->price = $price;
  }
}

class Tax
{
  static private float $ppn;

  static function calculate(Product $product)
  {
    Tax::set_tax($product->price);
    $tax = $product->price * Tax::$ppn;
    $total = $product->price + $tax;
    return "after tax {$product->name} price is {$total}";
  }

  static private function set_tax(float $price)
  {
    if ($price >= 175) {
      Tax::$ppn = 0.2;
    } else {
      Tax::$ppn = 0.1;
    }
  }
}

$shampoo = new Product("shampoo", 200);
$soap = new Product("soap", 100);

echo Tax::calculate($shampoo) . "\n";
echo Tax::calculate($soap) . "\n";
