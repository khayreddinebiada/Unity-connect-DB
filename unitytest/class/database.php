<?php
class database {
    public $link;

    public function __construct() {
      try {
        $this->link = mysqli_connect("localhost","root","","login");
      } catch (Exception $e) {
        if (mysqli_connect_errno())
            die("Connect is error");
      }
    }

    public function __construct2($server, $user, $pass,$db) {

      try {
        $this->link = mysqli_connect($server, $user, $pass,$db);
      } catch (Exception $e) {
        if (mysqli_connect_errno())
            die("Connect is error");
      }
    }

    public function insert($query){
        return mysqli_query($this->link, $query);
    }

    public function query($query){
        return mysqli_query($this->link, $query);
    }

    public function getRow($query){

        $re = mysqli_query($this->link, $query);
        if (mysqli_num_rows($re) == 0)
            return false;
        else
            return $re;
    }

}

$db = new database();
