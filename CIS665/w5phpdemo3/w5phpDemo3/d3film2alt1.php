<?php
/*
    Purpose: Demo3 - Accessing and displaying data from a DB
    Author: LV
    Date: January 2019
    Uses: siteCommon.php, d3Sql.php
    Demos: Preparing the output with a mix of PHP code
           and Html tags
*/

require_once ("../siteCommon.php");
require_once ("d3Sql.php");

// call the displayPageHeader method in siteCommon.php

displayPageHeader("Film Table <br /> Output prepared with a mix
            of PHP Code and Html Tags");

//Call the getFilmsList method

$filmsList = getFilmsList();

//Display the result in a table

?>

<!-- Embedding PHP code within Html tags -->

<section>
   <table>
      <caption> There are <?php echo count($filmsList) ?> films in the database 
      </caption>
      <colgroup>
         <col class="firstcol" />
      </colgroup>   
      <thead>
         <tr>
            <th>Film Title</th>
            <th>Films Pitch</th>
         </tr>
      </thead>
      <tbody>
      
      <?php

         foreach ($filmsList as $film)
         {
    
         // embedding Html tags within PHP code
    
            echo
            '<tr>
                <td>' . $film['movietitle']  . '</td>
                <td>' . $film['pitchtext'] . '</td>
            </tr>';
         }
      ?>

      </tbody>
</table>
</section>

<?php
    
    // call the displayPageFooter method in siteCommon.php

    displayPageFooter();
?>
