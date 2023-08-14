<?php

// interface allowed you to specify what methods a class should implement

interface Animal
{
  function eat();
  function breath();
}

class Dog implements Animal
{
  public function eat()
  {
    return "dog eats bones";
  }
  public function breath()
  {
    return "dog breaths with lungs";
  }
}

$dog = new Dog();
echo $dog->breath() . "\n";
echo $dog->eat() . "\n";
