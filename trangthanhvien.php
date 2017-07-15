<?php
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
            <li><a href="">Văn phòng cho thuê</a></li>               
           	<li><a href="">Liên hệ</a></li>
            <li><a href="">Lịch đăng ký</a></li>
            <li><a href="">Thành viên</a></li>
         </ul>
              
        </div>
</table>
<table align="center" class="mid" >
<tr><td>
<div id="anh_chay">
<marquee direction="left" behavior="alternate" onmouseover="this.stop()" onmouseout="this.start()">
     <img src="anh/anh2.jpg" width="900px" height="300px" />
     <img src="anh/anh3.jpg" width="900px" height="300px" />
     <img src="anh/anh4.jpg" width="900px" height="300px" />
    </marquee>
    </div></td>
</tr>
</table>
<table border="1px" width="220" align="left" style="margin-left:220px; margin-right:15px;">
	<tr>
    	<td class="member "width="210" bgcolor="#F4F4F4" >
        <a href="#"><h3> Thông tin người sử dụng.</h3></a>
    </td>
    </tr>
                <tr height="30px">
                	<td id="logout" align="right"><a href="dangxuat.php">Đăng xuất</a></td>
                </tr>
                </table>
                
<table width="665px" bgcolor="#FFFFCC" border="1px">
    <tr >
    <td>
    <a><h3>Giới thiệu chung</h3></a>
    
    	<img src="lienhe.jpg" style="width:150px; height:150px; float:right" />
        
        <a href="trangchututao.php"></a>
        
        <b>Văn phòng  tại NHA TRANG</b><br />
        <a>Đối với doanh nghiệp, trụ sở văn phòng thuận tiện và phù hợp luôn là mối bận tâm hàng đầu. Đặt văn phòng ở đâu? Diện           tích bao nhiêu và không gian như thế nào luôn là những câu hỏi được đặt ra để sao cho vừa phù hợp lĩnh vực hoạt động           cũng như khả năng tài chính. Hiểu được thực tế này, chúng tôi đã ra đời với mong muốn tiết kiệm thời gian và nguồn lực           cho doanh nghiệp. Tại đây chúng tôi đưa ra các gói tư vấn miễn phí tìm kiếm văn phòng, đàm phán giá, chuẩn bị hợp đồng           & tư vấn những ý tưởng trong việc bố trí mặt bằng & thi công văn phòng. Các gói dịch vụ của chúng tôi gồm:</a>
        <p>- Tư vấn thuê - cho thuê văn phòng hạng A, B, C, Văn phòng giá rẻ…</p>
        <p>- Tư  vấn văn phòng Ảo – văn phòng Trọn gói – phòng họp</p>
        <a>Chính sách phí áp dụng cho khách hàng:</a>
        <p>-   Chúng tôi miễn phí hoàn toàn phí dịch vụ tư vấn, môi giới cho các khách hàng có nhu cầu thuê văn phòng và cam kết         mang lại sự hài lòng cao nhất cho Quý khách hàng.</p>
		<p>-    Khuyến mại 01 gói Tư vấn Phong thủy cho văn phòng đối với các hợp đồng có giá trị trên 30 triệu và thời gian trên 			              3 năm.</p>
      </td>
     </tr>
</table>
</table>


</body>
</html>
