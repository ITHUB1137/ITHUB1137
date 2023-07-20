*{
    margin: 0;
    padding: 0;
}
body{
    background-color: #f1f3f4;
    font-family: sans-serif;
}
.top-nav-bar{
    height: 57px;
    top: 0;
    position: sticky;
    background: #ffffff;
    margin-bottom: 20px;
    border-bottom: 3px solid rgb(34, 0, 255);
    z-index: 2;
}
.logo{
    height: 40px;
    margin: 5px 10px;

}
.form-control{
    margin-top: 9px ;
    margin-left: 30px ;
    border:1px solid rgb(157, 255, 0) !important;
    border-top-left-radius: 20px !important;
    border-bottom-left-radius: 20px !important;
    border-top-right-radius: 0 !important;
    border-bottom-right-radius: 0 !important;
    box-shadow: none !important;

}
.input-group-text{
    background: rgb(255, 0, 72) !important;
    border: 1px solid rgb(0, 255, 60) !important;
    margin: 8.5px 10px 3px 0 !important;
    border-top-left-radius: 0px !important;
    border-bottom-left-radius: 0px !important;
    border-top-right-radius: 20px !important;
    border-bottom-right-radius: 20px !important;
    cursor: pointer;

}
.search-box{
    display: inline-flex;
    width: 60%;

}
.fa-search{
    color: #fff;
}
.menu-bar{
    width: 40%;
    height: 57px;
    float: right;
}
.menu-bar ul{
    display: inline-flex;
    float: right;
}
.menu-bar ul li{

    border-left: 1px solid #fff;
    list-style-type: none;
    padding: 15px 35px;
    text-align: center;
    background-color: rgb(0, 255, 60);
    cursor: pointer;
}
.menu-bar ul li a{
    font-size: 16px;
    font-weight: bold;
    color: #fff;
    text-decoration: none;
}
.fa-basket-shopping{
    margin-right: 5px;;
}
@media only screen and (max-width: 980px){
    .top-nav-bar{
        height: 118px;
        border-bottom: 0;
    }
    .search-box{
        width: 100%;
    }
    .menu-bar{
        width: 100%;
    }
    .menu-bar ul{
        margin 10px 0;
        width: 100%;
    }
    .menu-bar ul li{
        height: 57px;
        width: 100%;
    }
}
/* side-menu */
.side-menu{
    height: 79%;
    width: 15%;
    font-size: 14px;
    float: left;
    z-index: 2;
    background-color: #ddd;
}
.side-menu ul{
    margin-left: 10px;
}
.side-menu ul li{
    list-style-type: none;
    font-weight: bold;
    margin-top: 10px;
    cursor: pointer;
}
.side-menu ul li:hover{
    color: orange;
}
.side-menu ul li ul{
    display: none;
    z-index: 10;
    top: 77px;
}
.side-menu ul li:hover ul{
    display: block;
    height: 400px;
    margin-left: 14%;
    padding: 0 100px 10px 10px;
    position: fixed;
    background: #0c3025;
    box-shadow: 1px 1px 4px 1px rgba(0,0,0,0.5);
}
.fa-angle-right{
    margin-top: 4px;
    margin-right: 8px;
    float: right;
}
@media only screen and (max-width: 980px){
    .side-menu{
        width: 34%;
        z-index: 20;
        top: 133px;
        position: fixed;
        font-size: 12px;
    }
    .side-menu ul li ul{
        top: 133px;
    }
    .side-menu ul li ul{
        margin-left: 31%;
    }
}
