 <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<style>
	body table{ border:1px solid black;
	margin:auto;
	}
	@charset "utf-8";
/* CSS Document */
/*	MAIN CONTENT	*/
table#main-content{
border-left:1px solid #cdcdcd;
}
table#main-content tr td{
border-right:1px solid #cdcdcd;
border-bottom:1px solid #cdcdcd;
}

/*	NAVIGATION BAR	*/
table#main-content tr#main-navbar{
font-family:arial;
font-size:11px;
font-weight:bold;
color:#FFFFFF;
text-transform:uppercase;
background:url(images/admincp-bg-bar.gif) top left repeat-x;
}
table#main-content tr#main-navbar td{
padding:0px 10px;
}
table#main-content tr#main-navbar td a{
float:right;
color:#FFFFFF;
text-decoration:none;
}
table#main-content tr#main-navbar td a:hover{
text-decoration:underline;
}

/*	NAVIGATION TITLE	*/
table#main-content tr#navbar-title{
font-family:arial;
font-size:11px;
font-weight:bold;
color:#0f0f0f;
text-align:center;
text-transform:capitalize;
}

/*	PRODUCT ITEM	*/
table#main-content tr.product-item td, a{
font-family:arial;
font-size:11px;
color:#0085cf;
text-decoration:none;
}
table#main-content tr.product-item td.text{
padding-left:10px;
}
table#main-content tr.product-item td.img{
text-align:center;
padding:10px 10px;
}
table#main-content tr.product-item td.link{
text-align:center;
}
table#main-content tr.product-item td.red, a.red{
color:#FF0000;
text-decoration:none;
text-transform:capitalize;
}
table#main-content tr.product-item td a:hover{
text-decoration:underline;
}
table#main-content tr#list-num td a{
font-family:arial;
font-size:11px;
color:#0f0f0f;
padding-right:10px;
}
table#main-content tr#list-num td b a{
color:#0085cf;
}
</style>
</head>
<body>

 <table> 
   <?php
		 $connect_db = mysql_connect("localhost", "root", "");
		$select_db = mysql_select_db("hocmysql", $connect_db);
		$set_lang = mysql_query("SET NAMES 'utf8'");
		$sql = "SELECT * FROM phong";
		$query = mysql_query($sql);
		$num_row = mysql_num_rows($query);
 ?>
  
  
  
  
  
  <!-- Main Content -->
            <table width="640px" id="main-content" border="0px" cellpadding="0px" cellspacing="0px">
            	<tr id="main-navbar" height="36px">
                	<td colspan="8">quản lý sản phẩm <a href="trangchututao.php?page=themph">thêm sản phẩm mới (+)</a></td>
                </tr>
                <tr height="30px" id="navbar-title">
                	<td width="10%">số phòng</td>
                    <td width="10%">tầng</td>
                    <td width="15%">kích cở</td> 
                    <td width="25%">chi tiết</td>
                    <td width="15%">hình ảnh</td>
                    <td width="15%">giá phòng</td>
                    <td width="5%">sửa</td>
                    <td width="5%">xóa</td>
                </tr>
                
                <?php 
				if($num_row>0){
					while($row = mysql_fetch_array($query)){
				
				?>
                
                <tr class="product-item">
                	<td class="text"><?php echo $row["id_phong"];?></td>
                	<td class="text"><?php echo $row["so_phong"];?></td>
                    <td class="red text"><?php echo $row["vi_tri_tang"];?></td>
                    <td class="img"><?php echo $row["chi_tiet"];?></td>
                    <td class="text"><img width="130px" src="../anh_mo_ta/<?php echo $row["anh"];?>" /></td>
                    <td class="link"><?php echo $row["gia"];?> vnđ</td>
                    
                    <td class="link"><a class="red" href="trangchututao.php?page=suaphonghop&id_phong=<?php echo $row["id_phong"]?>">sửa</a></td>
                     <td class="link"><a class="red" href="trangchututao.php?page=xoaphonghop&id_phong=<?php echo $row["id_phong"];?>">xóa</a></td>
                </tr>
                
                
                
                
                    <?php
				
					}
				}
				else{
							
	echo "<script>alert(\"Hiện tại chưa có dữ liệu trong mục này!\")</script>";
}
				
?>
                
                
            </table>
 </table>
            
</body>
</html>