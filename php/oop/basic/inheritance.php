<?php

// how to create parent-child class relation
// how child class override parent method

declare(strict_types=1);
class Phone
{
  private float $_price;
  private int $_launchYear;
  private string $_brand;

  protected function __construct(float $price, int $launchYear, string $brand)
  {
    $this->_price = $price;
    $this->_launchYear = $launchYear;
    $this->_brand = $brand;
  }

  protected function getPhoneDetail()
  {
    return "price:{$this->_price}. year:{$this->_launchYear}. brand:{$this->_brand}";
  }
}

class Android extends Phone
{
  private string $_os;

  function __construct(string $os, float $price, int $launchYear, string $brand)
  {
    $this->_os = $os;
    parent::__construct($price, $launchYear, $brand);
  }

  function getPhoneDetail()
  {
    $phone = parent::getPhoneDetail();
    return "Android os:{$this->_os}. {$phone}";
  }
}

$android = new Android("Tiramisu", 5999, 2022, "Samsung");
echo "{$android->getPhoneDetail()}\n";
