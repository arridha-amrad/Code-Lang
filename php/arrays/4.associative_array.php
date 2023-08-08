<?php

$androids = ["a1"=>"android-nougat", "a2"=>"android-pie", "a3"=>"android-tiramisu"];
$iPhones = ["ip1"=>"ios-15", "ip2"=>"ios-16", "ip3"=>"ios-17"];

echo $androids["a2"] . "\n";
echo $iPhones["ip2"] . "\n";

foreach($iPhones as $key => $value){
  echo "Key={$key} Value={$value} \n";
}

?>