body {
    display: flex;
    flex-direction: column;
    height: 100vh;
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: arial, sans-serif;
    color: #222;
    font-size: 14px;
}

#container {
    margin:  10px 15px;
    display: flex;
    align-items: center;
}

#top-mid-nav {
    flex-grow: 1;
}

#top-right-nav {
    display: flex;
    align-items: center;
    font-size: 13px;    
}

a {
    color: inherit;
    text-decoration: none;
    padding: 10px;
}

a:hover {
    text-decoration: underline;
}

#app-icon {
    font-size: 25px;
    color: #78909c;
    margin: 0 15px;  
}

#profile-icon {
    font-size: 40px;
    color: #78909c;
    vertical-align: middle;    
}

.content {
    display: flex;
    position: relative;
    top: -25px;
    flex-direction: column;
    justify-content: center;
    height: 100vh;
    align-items: center;
}

#search-box {
    display: flex;
    box-sizing: border-box;
    height: 45px;
    align-items: center;
    width: auto;
    margin-top: 25px;
    border-radius: 25px;
    padding: 10px;
    border: 1px solid #dadce0;
}

#search-box:hover {
    outline-width: 0;
    border-right: 2px solid #dadce0;
    border-bottom: 2px solid #dadce0;
}

#search-icon {
    position: relative;
    top: 7px;
    color: #9aa0a6;
    font-size: 20px;
}

#search-bar {
    height: 28px;
    border: none;
    width: 530px;
}

#search-bar:focus {
    outline-width: 0;
}

.buttons {
    display: flex;
    justify-content: center;
    margin: 25px 0;
}

.button {
    margin: 5px;
    padding: 10px 15px;
    background-color: #f8f9fa;
    border: 1px solid transparent; 
    border-radius: 3px;  
}

#location-bar {
    border-bottom: 1px solid #dadce0;  
}

#location {
   color: #70757a;
   font-size: 15px;
   font-weight: 500;
   padding: 15px 30px;
   margin: 0;
}

#bot-bar {
    display: flex;
    justify-content: space-between;
}

.bot-style {
    display: flex;
    background-color: #f2f2f2;
    align-items: center;
    color: #70757a;  
}

#bot-left { 
    align-items: center;
    padding-left: 25px;   
}

#bot-mid {
    flex-grow: 1; 
    justify-content: center;
    align-content: center;
}

#carbon-neutral-logo {
    height: 15px;
    padding-right: 8px;
}

#bot-right {
    padding: 0 20px 0 90px;
}

.bot-links {
    padding-right: 20px;
}



.button:hover {
    border: 1px solid #dadce0;
}