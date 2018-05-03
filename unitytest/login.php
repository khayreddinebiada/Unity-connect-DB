<?php
  include ('class/database.php');

  if (isset($_POST["username"]) && isset($_POST["password"])) {

    $p_username = $_POST["username"];
    $p_password = $_POST["password"];

    $query = "SELECT password FROM player WHERE username = '$p_username'";
    $result = $db->getRow($query);

    if ($result) {
      if ($row = mysqli_fetch_assoc($result)){

        if ($p_password == $row["password"]) echo 1;
        else echo 0;

      }
    } else {

      echo -1;

    }

  } else {
    echo -2;
  }
?>
