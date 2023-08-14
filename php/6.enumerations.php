<?php
enum AndroidVersion
{
  case Nougat;
  case KitKat;
  case Pie;
  case Tiramisu;
}

function getOs(AndroidVersion $androidVersion)
{
  switch ($androidVersion) {
    case AndroidVersion::Nougat:
      echo "old os\n";
      break;
    default:
      echo "new os\n";
      break;
  }
}

getOs(AndroidVersion::Pie);
