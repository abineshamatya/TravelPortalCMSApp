$(document).ready(function ()
{

    $('#AddPackages').click(function (e)
    {
        //For adding package image

        if (window.FormData !== undefined)
        {
            var form = $('#AddPackageForm')[0];
            var dataString = new FormData(form);
            $.ajax({
                url: "/Admin/AddPackages",
                data: dataString,
                type: "post",

                //Options to tell jQuery not to process data or worry about content-type.
                cache: false,
                contentType: false, // Not to set any content header  
                processData: false, // Not to process data  
                success: function (data) {
                    //$("#messages").val($('#messages').val());
                    $('#messages').text(data);
                    setTimeout(3000);
                    $('#AddPackageForm').reset()
                },
                error: function (xhr, textStatus, errorThrown) {
                    alert(textStatus + ':' + errorThrown);
                    $('#messages').text("Error encountered while saving the package.");
                }
            });
        }
        else
        {
            alert("FormData is not supported.");
        }

        ////For adding package details

        //var PackageName = $('#PackageName').val();
        //var Destination = $('#Destination').val();
        //var Type = $('#Type').val();
        //var Cost = $('#Cost').val();
        //var Days = $('#Days').val();
        //var Description = $('#Description').val();

        //$.ajax({
        //    url: "/Admin/AddPackages",
        //    data: { 'PackageName': PackageName, 'Cost': Cost, 'Type': Type, 'Destination': Destination, 'Days': Days, 'Description': Description },
        //    type: "post",
        //    success: function (data) {
        //        //$("#messages").val($('#messages').val());
        //        $('#messages').text(data);

        //    },
        //    error: function (xhr, textStatus, errorThrown) {
        //        alert(textStatus + ':' + errorThrown);
        //        $('#messages').text("Error encountered while saving the packages details.");
        //    }
        //});
       

       

        e.preventDefault();
        //e.getPreventDefault();
    });
    $('#AddSlider').click(function (e) {
        //For adding package image

        if (window.FormData !== undefined) {
            var form = $('#AddSliderForm')[0];
            var dataString = new FormData(form);
            $.ajax({
                url: "/Admin/AddSlider",
                data: dataString,
                type: "post",

                //Options to tell jQuery not to process data or worry about content-type.
                cache: false,
                contentType: false, // Not to set any content header  
                processData: false, // Not to process data  
                success: function (data) {
                    //$("#messages").val($('#messages').val());
                    $('#messages').text(data);
                    setTimeout(3000);
                    $('#AddSliderForm').reset()
                },
                error: function (xhr, textStatus, errorThrown) {
                    alert(textStatus + ':' + errorThrown);
                    $('#messages').text("Error encountered while saving the package.");
                }
            });
        }
        else {
            alert("FormData is not supported.");
        }


        e.preventDefault();
        //e.getPreventDefault();
    });
    $('#Addbanner').click(function (e) {
        //For adding package image
        alert("test")
        if (window.FormData !== undefined) {
            var form = $('#AddbannerForm')[0];
            var dataString = new FormData(form);
            $.ajax({
                url: "/Admin/banner",
                data: dataString,
                type: "post",

                //Options to tell jQuery not to process data or worry about content-type.
                cache: false,
                contentType: false, // Not to set any content header  
                processData: false, // Not to process data  
                success: function (data) {
                    //$("#messages").val($('#messages').val());
                    $('#message').text(data);
                    setTimeout(1000);
                    $('#AddbannerForm').reset()
                },
                error: function (xhr, textStatus, errorThrown) {
                    alert(textStatus + ':' + errorThrown);
                    $('#messages').text("Error encountered while saving the banner.");
                }
            });
        }
        else {
            alert("FormData is not supported.");
        }


        e.preventDefault();
        //e.getPreventDefault();
    });
    $('#welcome').click(function (e) {
        //For adding package image
        alert("test")
        if (window.FormData !== undefined) {
            var form = $('#welcomeForm')[0];
            var dataString = new FormData(form);
            $.ajax({
                url: "/Admin/welcome",
                data: dataString,
                type: "post",

                //Options to tell jQuery not to process data or worry about content-type.
                cache: false,
                contentType: false, // Not to set any content header  
                processData: false, // Not to process data  
                success: function (data) {
                    //$("#messages").val($('#messages').val());
                    $('#messages').text(data);
                    setTimeout(1000);
                    $('#welcomeForm').reset()
                },
                error: function (xhr, textStatus, errorThrown) {
                    alert(textStatus + ':' + errorThrown);
                    $('#messages').text("Error encountered while saving the banner.");
                }
            });
        }
        else {
            alert("FormData is not supported.");
        }


        e.preventDefault();
        //e.getPreventDefault();
    });
});



