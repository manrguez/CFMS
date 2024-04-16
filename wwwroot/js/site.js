$(document).ready(function () {
    $.ajaxSetup({ cache: false });
});

function LoadModalContent(urlAction) {
    debugger;
    $("#modalContent").load(urlAction);
};

//function to create object and reload list.
//types: Feedback or Responses
function Create(type) {

    //validate inputs
    if (!ValidateFrm())
        return;

    //get verification token
    var token = $("input[name='__RequestVerificationToken']").val();

    $.ajax({
        url: '/' + type + '/Create/',
        type: 'POST',
        headers:
        {
            "RequestVerificationToken": token
        },
        data: $('form').serialize(),
        success: function (response) {

            ClearData();
            $('#btnClose').click();

            //look for feedbackId to reload responses and pass it to the controller
            var id = "";
            if ($("[name='FeedbackId']").val() && $("[name='FeedbackId']").val() > 0)
                id = $("[name='FeedbackId']").val();

            ReloadList('/' + type + '/ListPartial/' + id );           
        },
        error: function (xhr, status, error) {
            console.error('Error on CreateFeedback: ', error);
        }
    })
};

function ReloadList(url) {

    $.ajax({
        url: url, 
        type: 'GET',
        success: function (response) {

            $('#containerList').html(response);

        },
        error: function (xhr, status, error) {
            console.error('Error on ReloadFeedbacks:', error);
        }
    });
}

function ValidateFrm(isFeedback = true) {

    var isValid = true;
    var customerName = $('#CustomerName');
    var category = $('#Category');
    var description = $('#Description');  
   

    if ($.trim(customerName.val()) != '') {
        customerName.closest('.form-group').removeClass('has-error');
        isValid = true;
    } else {
        customerName.closest('.form-group').addClass('has-error');
        isValid = false;
    }

    if (isFeedback == true) {
        if ($.trim(category.val()) != '') {
            category.closest('.form-group').removeClass('has-error');
            isValid = true;
        } else {
            category.closest('.form-group').addClass('has-error');
            isValid = false;
        }
    }

    if ($.trim(description.val()) != '') {
        description.closest('.form-group').removeClass('has-error');
        isValid = true;
    } else {
        description.closest('.form-group').addClass('has-error');
        isValid = false;
    }           

    return isValid;
};

function ClearData() {
    $('#modalCreate').find('textarea,input').val('');
};

function EditFeedback(id) {

    //validate inputs
    if (!ValidateFrm())
        return;

    //get verification token
    var token = $("input[name='__RequestVerificationToken']").val();

    $.ajax({
        url: '/Feedbacks/Edit/' + id,
        type: 'POST',
        headers:
        {
            "RequestVerificationToken": token
        },
        data: $('form').serialize(),
        success: function (response) {

            ClearData();
            $('#btnClose').click();

            ReloadList('/Feedbacks/ListPartial');  
        },
        error: function (xhr, status, error) {
            console.error('Error on EditFeedback: ', error);
        }
    })
};

function EditResponse(id, feedbackId) {

    //validate inputs
    if (!ValidateFrm(false))
        return;

    //get verification token
    var token = $("input[name='__RequestVerificationToken']").val();

    $.ajax({
        url: '/Responses/Edit/' + id,
        type: 'POST',
        headers:
        {
            "RequestVerificationToken": token
        },
        data: $('form').serialize(),
        success: function (response) {

            ClearData();
            $('#btnClose').click();

            ReloadList('/Responses/ListPartial/' + feedbackId);
        },
        error: function (xhr, status, error) {
            console.error('Error on EditResponse: ', error);
        }
    })
};