events: function () {
    $(document).ready(function () {

        $('.edit-student').off('click').on('click', function () {
            $('#exampleModal').modal('show');
            var id = $(this).data('id');
            //var idadd = $(this).data('address');

            $.ajax({
                url: "/Home/GetStudent",
                data: {
                    id: id,
                    //idAddress: idadd
                },
                dataType: "json",
                type: "GET",
                success: function (response) {
                    var data = response.student;
                    //var address = response.address;
                    $('#Id').val(Id);
                    //$('#IdAddress').val(idadd);
                    $('#Address').val(data.Address);
                    $('#Name').val(data.Name);
                    $('#Yob').val(data.Yob);
                    $('#Phone').val(data.Phone);
                    //student.loadAddress(address.id, address.quanHuyenID, address.tinhThanhID);
                }
            });


        });


    });
