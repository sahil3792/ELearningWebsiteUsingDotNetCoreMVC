
$(document).ready(function () {
    GetCategory();
    GetCategoryforCourse();
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
            var options = '<option value="">Select Category</option>';
            $.each(result, function (index, item) {
                options += "<option value='" + item.categoryId + "' asp-for='CategoryId' name='CategoryId'>" + item.categoryName + "</option>";
            });
            $("#DropdownData").html(options);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Failed to load categories: " + xhr.status + " - " + error);  // Provide more detailed info
        }
    });
}


$('#SaveSubCategoryButton').click(function () {
    var obj = $('#SubCategoryForm').serialize();
    $.ajax({
        url: 'Admin/AddSubCategory',
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

})


function GetCategoryforCourse() {
    $.ajax({
        url: '/Admin/GetCategory',  // Adjust the URL to the new action
        type: 'GET',
        dataType: 'json',
        success: function (result, status, xhr) {
            var options = '<option value="">Select Category</option>';
            $.each(result, function (index, item) {
                options += "<option value='" + item.categoryId + "' asp-for='CategoryId' name='CategoryId'>" + item.categoryName + "</option>";
            });
            $("#DisplayCategory").html(options);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Failed to load categories: " + xhr.status + " - " + error);  // Provide more detailed info
        }
    });
}


function GetSubCategoryData() {
    
    var selectedCategoryId = $("#DisplayCategory").val();
    

    $.ajax({
        url: '/Admin/BindSubCategory?id=' + selectedCategoryId,
        type: 'GET',
        dataType: 'json',
        success: function (result, status, xhr) {
            var options = '<option value="">Select Category</option>';
            $.each(result, function (index, item) {
                options += "<option value='" + item.subCategoryId + "' asp-for='CategoryId' name='CategoryId'>" + item.subCategoryName + "</option>";
            });
            $("#DisplaySubCategory").html(options);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Failed to load categories: " + xhr.status + " - " + error);  // Provide more detailed info
        }
    });

}
function GetCourseData() {

    var selectSubcategoryid = $("#DisplaySubCategory").val();
    alert("called" + selectSubcategoryid);

    $.ajax({
        url: '/Admin/BindCourse?id=' + selectSubcategoryid,
        type: 'GET',
        dataType: 'json',
        success: function (result, status, xhr) {
            var options = '<option value="">Select Category</option>';
            $.each(result, function (index, item) {
                options += "<option value='" + item.courseId + "' asp-for='CategoryId' name='CategoryId'>" + item.courseName + "</option>";
            });
            $("#DisplayCourseDropdown").html(options);
        },
        error: function (xhr, status, error) {
            console.error("Error fetching data: ", error);  // Log error details
            alert("Failed to load categories: " + xhr.status + " - " + error);  // Provide more detailed info
        }
    });

}


$('#SaveVideobtn').click(function () {
    var obj = $('#VideoForm').serialize();
   
    $.ajax({
        url: '/Admin/StoreVideo',
        type: 'Post',
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf8',
        data: obj,
        success: function () {
            alert("Emp Added Successfully");

        },
        error: function () {
            alert("Something went Wrong");
        }
    });
})