<?php

// 3 access modifier: public, private, protected

declare(strict_types=1);

class User
{
  public $name;
  public $age;
  public $isMarried;

  public function set_name(string $name)
  {
    $this->name = $name;
  }

  public function greet()
  {
    echo "{$this->name} says hello\n";
  }

  public function getUserDetail()
  {
    echo "name:{$this->name}. age:{$this->age}. isMarried:{$this->isMarried}\n";
  }
}

$user = new User();
$user->set_name("Alex");
$user->greet();