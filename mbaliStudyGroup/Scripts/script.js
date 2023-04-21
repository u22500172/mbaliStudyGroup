var x = document.getElementsByClassName("rowcontent");



//Delete function
//resource: https://www.w3schools.com/jsref/met_table_deleterow.asp 
function DeleteStudent(r) {
    var i = r.parentNode.parentNode.rowIndex;
    document.getElementById("studentTable").deleteRow(i);
}


//Color chnage 
const pattern = /M/;
for (let i = 0; i < x.length; i++) {

    if (pattern.test(x[i].cells[1].innerText))

        x[i].style.color = "red";
}



//Toggale Function
// resources: https://www.w3schools.com/howto/tryit.asp?filename=tryhow_js_full_page_tabs

function OpenTab(tabName, element) {
    var tabContent = document.getElementById("tab-content");
    var tabLinkName = document.getElementsByClassName("tabName");

    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    


    document.getElementById(tabName).style.display = "block";


}


