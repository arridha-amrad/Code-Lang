<?php

declare(strict_types=1);
class User
{
  private string $_name;
  private int $_age;
  private float $_height;

  function __construct(string $name, int $age, float $height)
  {
    $this->_name = $name;
    $this->_age = $age;
    $this->_height = $height;
  }

  function getUserData()
  {
    return "name:{$this->_name}. age:{$this->_age}. height:{$this->_height}cm";
  }
}

$user = new User("Jack", 24, 188.34);
echo $user->getUserData() . "\n";
