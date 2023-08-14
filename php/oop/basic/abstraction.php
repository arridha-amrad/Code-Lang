<?php

declare(strict_types=1);

abstract class Creature
{
  public $name;
  function __construct(string $name)
  {
    $this->name = $name;
  }
  function set_name(string $name)
  {
    $this->name = $name;
  }
  abstract function breath(): string;
  abstract function getFoods(): array;
}

class Human extends Creature
{
  function __construct(string $name)
  {
    $this->name = $name;
  }

  function breath(): string
  {
    $name = $this->name;
    return "{$name} breathing with lungs";
  }

  function getFoods(): array
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

  function breath(): string
  {
    return "{$this->name} breathing with gill";
  }

  function getFoods(): array
  {
    return ["small-fish", "moss", "poop"];
  }
}

$human = new Human("Jack");
$catFish = new Fish("Cat-Fish");

$human->set_name("Bill");
echo $human->breath() . "\n";
echo $catFish->breath() . "\n";
echo $catFish->name . " eats " . join(", ", $catFish->getFoods()) . "\n";
