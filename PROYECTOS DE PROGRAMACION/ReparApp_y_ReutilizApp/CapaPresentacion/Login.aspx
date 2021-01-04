<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

	<link rel="stylesheet" type="text/css" href="css/font-awesome.css"/>
	<link rel="stylesheet" type="text/css" href="css/menu.css"/>
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/function.js"></script>

<link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" rel="stylesheet"/>
<script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <title></title>
</head>
<body>

    <div id="wrap">
	<header>
		<div class="inner relative">
			<a class="logo" href="http://www.freshdesignweb.com"><img src="images/logo.png" alt="fresh design web"></a>
			<a id="menu-toggle" class="button dark" href="#"><i class="icon-reorder"></i></a>
			<nav id="navigation">
				<ul id="main-menu">
					<li class="current-menu-item"><a href="http://www.freshdesignweb.com">Inicio</a></li>
					<li class="parent">
						<a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Features</a>
						<ul class="sub-menu">
							<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html"><i class="icon-wrench"></i> Elements</a></li>
							<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html"><i class="icon-credit-card"></i>  Pricing Tables</a></li>
							<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html"><i class="icon-gift"></i> Icons</a></li>
							<li>
								<a class="parent" href="#"><i class="icon-file-alt"></i> Pages</a>
								<ul class="sub-menu">
									<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Full Width</a></li>
									<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Left Sidebar</a></li>
									<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Right Sidebar</a></li>
									<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Double Sidebar</a></li>
								</ul>
							</li>
						</ul>
					</li>
					<li><a href="Ayuda.aspx">Ayuda</a></li>
					<li><a href="http://www.freshdesignweb.com/responsive-drop-down-menu-jquery-css3-using-icon-symbol.html">Contactanos</a></li>
				</ul>
			</nav>
			<div class="clear"></div>
		</div>
	</header>	
</div>    

<div class="container">
	<div class="row">
        <div class="span12">
    		<div class="" id="loginModal">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                <h3>Tienes una cuenta?</h3>
              </div>
              <div class="modal-body">
                <div class="well">
                  <ul class="nav nav-tabs">
                    <li class="active"><a href="#login" data-toggle="tab">Inicio de sesion</a></li>
                    <li><a href="#create" data-toggle="tab">Crear Cuenta</a></li>
                  </ul>
                  <div id="myTabContent" class="tab-content">
                    <div class="tab-pane active in" id="login">
                      <form class="form-horizontal" action='' method="POST">
                        <fieldset>
                          <div id="legend">
                            <legend class="">Iniciar</legend>
                          </div>    
                          <div class="control-group">
                            <!-- Username -->
                            <label class="control-label"  for="username">Nombre de usuario</label>
                            <div class="controls">
                              <input type="text" id="username" name="username" placeholder="" class="input-xlarge"/>
                            </div>
                          </div>
     
                          <div class="control-group">
                            <!-- Password-->
                            <label class="control-label" for="password">Contraseña</label>
                            <div class="controls">
                              <input type="password" id="password" name="password" placeholder="" class="input-xlarge"/>
                            </div>
                          </div>
     
     
                          <div class="control-group">
                            <!-- Button -->
                            <div class="controls">
                              <button class="btn btn-success">iniciar</button>
                            </div>
                          </div>
                        </fieldset>
                      </form>                
                    </div>
                    <div class="tab-pane fade" id="create">
                      <form id="tab">
                        <label>Nombre de usuario</label>
                        <input type="text" value="" class="input-xlarge"/>
                        <label>Nombre</label>
                        <input type="text" value="" class="input-xlarge"/>
                        <label>Apellido</label>
                        <input type="text" value="" class="input-xlarge"/>
                        <label>Email</label>
                        <input type="text" value="" class="input-xlarge"/>
                        <label>Direccion</label>
                        <textarea value="Smith" rows="3" class="input-xlarge">
                        </textarea>
     
                        <div>
                          <button class="btn btn-primary">Crear Cuenta</button>
                        </div>
                      </form>
                    </div>
                </div>
              </div>
            </div>
        </div>
	</div>
</div>


</body>
</html>
