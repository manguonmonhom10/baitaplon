<?php
error_reporting(E_ALL & ~E_NOTICE & ~E_DEPRECATED);
ob_start();
session_start();
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<style>
	body{
		background-color:#FFF;
		border:1px solid while;
		}
	body, table, td,tr,img, div,{border-radius:5px;}

	#anh_chay{border:1px double #333333;}
	.mid{
		width: 900px;
		height: 300px;
		}
			
	/*-- Menu------*/

		.wrapper{ 
			width: 900px; 
			height:50px; 
			background: #F8F8F8;
			margin:auto; }
		ul{
			margin:0;
			padding:0;
		}
		li{
			list-style-type:none;
			float:left;
			padding:10px;
			}
		li a{
			display:block;
			padding:10px;
			text-decoration:none;
			line-height:1px;
			min-height:1px;
			color:#F00;
			}
		li a:hover{
			background-color:#FFF;
			color:#000;
		}
		.sub_menu{
			position:absolute;
			display:none;
		}
		.menu:hover .sub_menu{
			display:block;
		}
		.sub_menu li{
			float:none;
			}
		
	
	
</style>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.min.css">
</head>

<body>


<table align="center">
<tr align="right">
	<td>
    	<a><i class="fa fa-phone"> Hostline:0972280223</i></a> 
    	<a><i class="fa fa-envelope"> Email:nguyenxuanphi216@gmail.com</i></a>  
	</td>
</tr>
<tr>
	<td> <img src="anh/anh1.jpg" width="900px" height="200px" /></td>
</tr>
<table bgcolor="#EAEAEA" align="center" width="900px" >
    <div class="wrapper">
    	 <ul>
 			<li><img src="anh/logo.jpg" width="80px" height="25px" /></li>
         	<li><a href="">Trang chủ</a></li>
            <li><a href="gioithieu.php">Giới thiệu</a></li>
            <li><a href="trangchu.php">Văn phòng cho thuê</a></li>              
           	<li><a href="lienhe.php">Liên hệ</a></li>
            <li><a href="dangnhap.php">Đăng nhập</a></li>
            <li><a href="dangky.php">Đăng kí</a></li>
         </ul>
              
        </div>
</table>
<table align="center" class="mid" >
<tr>
	<td>
<div id="anh_chay">
<marquee direction="left" behavior="alternate" onmouseover="this.stop()" onmouseout="this.start()">
     <img src="anh/anh2.jpg" width="900px" height="300px" />
     <img src="anh/anh3.jpg" width="900px" height="300px" />
     <img src="anh/anh4.jpg" width="900px" height="300px" />
    </marquee>
    </div>
    </td>
</tr>
</table>
      	<!-- Left Menu -->
            <table align="left" style="margin-left:220px; margin-right:10px" bgcolor="#CCCCCC" width="200px" class="left-menu" border="1px" cellpadding="2px" cellspacing="0px">
            	<tr class="bg-leftbar" height="36px" boder="1px">
                	<td>Quản Trị Admin</td>
                </tr>
                <tr  height="30px">
                    <td><a href="trangchututao.php">trang chủ</a></td>
                </tr>
                <tr  height="30px">
                    <td><a href="trangchututao.php?page=nguoidung">Danh Sách Người Sử Dụng</a></td>
                </tr>
                <tr  height="30px">
                    <td><a href="trangchututao.php?page=phonghop">Danh Sách Phòng Họp</a></td>
                </tr>
                <tr  height="45px">
                    <td><a href="trangchututao.php?page=lich"> Danh Sách Lịch Đăng Kí</a></td>
                </tr>
                
                <tr  height="30px">
                    <td><a href="trangchututao.php?page=nguoidung">Thông Tin Người Sử Dụng</a></td>
                </tr>
                <tr height="30px">
                	<td id="logout" align="right"><a href="dangxuat.php">Đăng xuất</a></td>
                </tr>
                </table>
                <table bgcolor="#FFFFCC" width="680px" border="1px" style="margin-left:0px;">
					<tr>
    					<td>
						<?php
                        switch($_GET["page"])
                        {
                        case "nguoidung": include_once("thongtinthanhvien.php");
                        break;
                                    
                        case "phonghop": include_once("danhsachphong.php");
                        break;
                                    
                        case "lich": include_once("lich.php");
                        break;
                        
                        case "nguoidung": include_once("thongtinthanhvien.php");
                        break;
                        
                        case "themnd": include_once("themnd.php");
                        break;
			
						case "themph": include_once("themph.php");
							break;
							default: include_once("gioithieunguoidung.php");		
							}
							?>  
            		</td>
            	</tr>             
</body>
</html>
