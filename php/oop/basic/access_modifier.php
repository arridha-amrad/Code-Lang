<?php

// 3 access modifier: public, private, protected

declare(strict_types=1);

class User
{
  private $name;
  private $age;
  private $isMarried;

  function __construct(string $name, int $age, bool $isMarried)
  {
    $this->name = $name;
    $this->age = $age;
    $this->isMarried = $isMarried;
  }

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
    $status = $this->isMarried ? "yes" : "no";
    echo "name:{$this->name}. age:{$this->age}. isMarried:{$status}\n";
  }
}

$user = new User("alex", 22, false);
$user->set_name("Alex");
$user->greet();
$user->getUserDetail();
