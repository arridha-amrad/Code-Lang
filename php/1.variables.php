<?php

// variable start with $;
// followed by underscore or any letter
// followed by any number of letters, numbers, underscores

$name = "Arridha Amrad";

$_4You = "4 you";

$__username___ = "amrad21";


// echo $name . "\n";
// echo $_4You . "\n";
// echo $__username___ . "\n";

$foo = 'Bob';              // Assign the value 'Bob' to $foo
$bar = &$foo;              // Reference $foo via $bar.
$bar = "My name is $bar";  // Alter $bar...
echo $bar . "\n";
echo $foo . "\n";
