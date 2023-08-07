<?php

declare(strict_types=1);

function spinWords(string $words): string
{
  $arrWords = explode(" ", $words);
  for ($i = 0; $i < count($arrWords); $i++) {
    if (strlen($arrWords[$i]) >= 5) {
      $arrWords[$i] = strrev($arrWords[$i]);
    }
  }
  return join(" ", $arrWords);
}

// TEST
echo (spinWords("Hey fellow warriors") === "Hey wollef sroirraw");
echo (spinWords("This is a test") === "This is a test");
echo (spinWords("This is another test") === "This is rehtona test");
