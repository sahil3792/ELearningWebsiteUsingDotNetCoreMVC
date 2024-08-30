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
        url: '/Admin/GetCategory',
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf8;',
        success: function (result) {
            var options = '<option value="">Select Category</option>';  // Default option
            $.each(result, function (index, item) {
                options += "<option value='" + item.categoryId + "'>" + item.categoryname + "</option>";
            });
            $("#DropdownData").html(options);  // Populate the dropdown with options
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Data not found: " + error);  // Provide more info in the alert
        }
    })
}