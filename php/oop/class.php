<?php

declare(strict_types=1);

class User
{

  private $name;
  public $age;
  private $isMarried;

  function __construct(string $name, int $age, bool $isMarried)
  {
    $this->name = $name;
    $this->age = $age;
    $this->isMarried = $isMarried;
  }

  function __destruct()
  {
    echo "your name is {$this->name}";
  }

  function greet(string $message)
  {
    return "You said : " + $message;
  }

  // function set_name(string $name) {
  //   $this->name = $name;
  // }

  // function get_name(): string {
  //   return $this->name;
  // }

}

$ari = new User("ari", 28, false);

  // var_dump($ari instanceof User);
