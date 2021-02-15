
function change(button, comand)
    {
        var defalt_color="rgb(185, 187, 192)";
        var clicked_color="rgb(0, 92, 230)";

        document.getElementById('creat').style.backgroundColor=defalt_color;
        document.getElementById('creat').style.textShadow="0px 0px 0px";
        document.getElementById('sub_mit').style.visibility="hidden";
        
        document.getElementById('update').style.backgroundColor=defalt_color;
        document.getElementById('update').style.textShadow="0px 0px 0px";
        document.getElementById('up_date').style.visibility="hidden";
        
        document.getElementById('delect').style.backgroundColor=defalt_color;
        document.getElementById('delect').style.textShadow="0px 0px 0px";
        document.getElementById('de_lect').style.visibility="hidden";

        document.getElementById('heading').innerHTML=comand;
        button.style.backgroundColor=clicked_color;
        button.style.textShadow ="5px 5px 5px #000000";

        if(comand=="Delect data")
            {
                document.getElementById('de_lect').style.visibility="visible";
                document.getElementById('ceo_name').style.visibility="hidden";
                document.getElementById('y_income').style.visibility="hidden";
            } 
        else if(comand=="Update data")
            {
                document.getElementById('up_date').style.visibility="visible";
                document.getElementById('ceo_name').style.visibility="visible";
                document.getElementById('y_income').style.visibility="visible";
                document.getElementById('com_name').style.visibility="visible";

            }             
        else
            {
                document.getElementById('sub_mit').style.visibility="visible";
                document.getElementById('ceo_name').style.visibility="visible";
                document.getElementById('y_income').style.visibility="visible";
                document.getElementById('com_name').style.visibility="visible";

            }
    }

function creat()
    {
        // var count=2;
        var creat=document.getElementById('creat');
        change(creat,"Creat data");                
    }
function update()
    {
        // var count=1;
        var update=document.getElementById('update');
        change(update, "Update data");        
    }

function delect()
    {
        // var count=1;
        var delect=document.getElementById('delect');
       change(delect, "Delect data");        
    }