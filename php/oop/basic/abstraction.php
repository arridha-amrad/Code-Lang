<?php

declare(strict_types=1);

abstract class Creature
{
  public $name;
  function __construct(string $name)
  {
    $this->name = $name;
  }
  abstract function breath();
  abstract function getFoods();
}

class Human extends Creature
{
  function __construct(string $name)
  {
    $this->name = $name;
  }

  function breath()
  {
    $name = $this->name;
    return "{$name} breathing with lungs";
  }

  function getFoods()
  {
    return ["rice", "fish", "meat"];
  }
}

class Fish extends Creature
{
  function __construct(string $name)
  {
    $this->name = $name;
  }

  function breath()
  {
    return "{$this->name} breathing with gill";
  }

  function getFoods()
  {
    return ["small-fish", "moss", "poop"];
  }
}

$human = new Human("Jack");
$catFish = new Fish("Cat-Fish");

echo $human->breath() . "\n";
echo join(", ", $catFish->getFoods()) . "\n";
