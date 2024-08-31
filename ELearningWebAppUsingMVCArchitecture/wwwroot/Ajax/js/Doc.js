$(document).ready(function () {
    GetCategory();
});

$('#AddCategory').click(function () {
    $('#CategoryModal').modal('show');


});
$('#AddSubCategory').click(function () {
    $('#SubCategoryModal').modal('show');



});

$('#AddSubCategoryClose').click(function () {
    $('#CategoryModal').modal('hide');
    $('#SubCategoryModal').modal('show');
})

$('#CloseCategory').click(function () {
    $('#CategoryModal').modal('hide');
})
$('#CloseSubCategory').click(function () {
    $('#SubCategoryModal').modal('hide');
})

$('#SaveCategoryButton').click(function () {

    var obj = $('#CategoryForm').serialize();
    $.ajax({
        url: 'Admin/CategoriesSub',
        type: 'Post',
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf8',
        data: obj,
        success: function () {
            alert("Category Added Successfully");
            clear();
        },
        error: function () {
            alert("Something went Wrong");
        }
    });
});

function GetCategory() {
    $.ajax({
        url: '/Admin/GetCategory',  // Adjust the URL to the new action
        type: 'GET',
        dataType: 'json',
        success: function (result, status, xhr) {
            obj = '';
            $.each(result, function (index, item) {
                obj += "<option>"+item.categoryName+"<option>";
            });
            $("#DropdownData").html(obj);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Failed to load categories: " + xhr.status + " - " + error);  // Provide more detailed info
        }
    });
}