
    // Tüm tablo için arama fonksiyonu
    function filterTable() {
        let searchText = document.getElementById('globalSearch').value.toLowerCase();
        let table = document.getElementById('dataTable');
        let rows = table.getElementsByTagName('tbody')[0].getElementsByTagName('tr');

        for (let row of rows) {
            let cells = row.getElementsByTagName('td');
            let found = false;
            for (let cell of cells) {
                if (cell.textContent.toLowerCase().includes(searchText)) {
                    found = true;
                    break;
                }
            }
            row.style.display = found ? '' : 'none';
        }
    }
    $(document).ready(function () {
        $("#openMusteriModal").click(function () {
            $("#musteriModalContent").load("/Musteri/CreateMusteri", function () {
                $("#musteriModal").modal("show");
            });
        });
    });
    

       function initAutocomplete() {
        const input = document.getElementById('adresInput');
        const autocomplete = new google.maps.places.Autocomplete(input);
        }

    // Filtre ikonlarına tıklama olayı ekleyelim
    document.querySelectorAll('.bi-filter').forEach((icon, index) => {
        icon.addEventListener('click', function() {
            let filterInput = icon.nextElementSibling.querySelector('input');
            let clearIcon = icon.nextElementSibling.querySelector('.bi-x-circle-fill');
            
            filterInput.classList.toggle('d-none');
            if (!filterInput.classList.contains('d-none')) {
                filterInput.focus();
                if (filterInput.value.length > 0) {
                    clearIcon.style.display = 'block';
                }
            } else {
                clearIcon.style.display = 'none';
            }
        });
    });

    function filterColumn(event, columnIndex) {
        let filterValue = event.target.value.toLowerCase();
        let table = document.getElementById('dataTable');
        let rows = table.getElementsByTagName('tbody')[0].getElementsByTagName('tr');
        let clearIcon = event.target.nextElementSibling;
        let th = table.getElementsByTagName('th')[columnIndex];

        // Filtre durumunu güncelle
        if (filterValue.length > 0) {
            th.classList.add('filtered');
            clearIcon.style.display = 'block';
        } else {
            th.classList.remove('filtered');
            clearIcon.style.display = 'none';
        }

        // Filtreleme işlemi
        for (let row of rows) {
            let cell = row.getElementsByTagName('td')[columnIndex];
            if (cell) {
                let text = cell.textContent || cell.innerText;
                if (text.toLowerCase().indexOf(filterValue) > -1) {
                    row.style.display = '';
                } else {
                    row.style.display = 'none';
                }
            }
        }
    }

    function clearFilter(columnIndex) {
        let table = document.getElementById('dataTable');
        let headers = table.getElementsByTagName('th');
        let filterInput = headers[columnIndex].querySelector('input');
        let clearIcon = headers[columnIndex].querySelector('.bi-x-circle-fill');
        let th = headers[columnIndex];
        
        filterInput.value = '';
        clearIcon.style.display = 'none';
        th.classList.remove('filtered');
        filterColumn({ target: filterInput }, columnIndex);
    }

    // Dışarı tıklandığında filtreleri kapat
    document.addEventListener('click', function(event) {
        if (!event.target.closest('.position-relative') && !event.target.classList.contains('bi-filter')) {
            document.querySelectorAll('.form-control-sm').forEach(input => {
                input.classList.add('d-none');
            });
            document.querySelectorAll('.bi-x-circle-fill').forEach(icon => {
                icon.style.display = 'none';
            });
        }
    });

    // Enter tuşuna basıldığında global arama yapılması için
    document.getElementById('globalSearch').addEventListener('keypress', function(e) {
        if (e.key === 'Enter') {
            filterTable();
        }
    });

    // Tüm filtre inputları için event listener ekleme
    document.querySelectorAll('th input').forEach((input, index) => {
        input.addEventListener('keyup', (e) => filterColumn(e, index));
    });

    // Filtre inputlarına tıklandığında event'in yukarı yayılmasını engelleyelim
    document.querySelectorAll('th input').forEach(input => {
        input.addEventListener('click', function(event) {
            event.stopPropagation();
        });
    });

    // Filtre ikonlarına tıklandığında event'in yukarı yayılmasını engelleyelim
    document.querySelectorAll('.bi-filter').forEach(icon => {
        icon.addEventListener('click', function(event) {
            event.stopPropagation();
        });
    });

    // X ikonuna tıklandığında event'in yukarı yayılmasını engelleyelim
    document.querySelectorAll('.bi-x-circle-fill').forEach(icon => {
        icon.addEventListener('click', function(event) {
            event.stopPropagation();
        });
    });

    $(document).ready(function() {
        // Telefon maskeleri
        var telefonBehavior = function (val) {
            return '0(000) 000 00 00';
        },
        telefonOptions = {
            onKeyPress: function(val, e, field, options) {
                field.mask(telefonBehavior.apply({}, arguments), options);
            },
            clearIfNotMatch: false,
            placeholder: "0(___) ___ __ __"
        };

        $('#firmaTelefonu, #cepTelefonu').mask(telefonBehavior, telefonOptions);
    });

    // Telefon maskesi için yeni fonksiyon
    function formatPhoneNumber(input) {
        // Sadece rakamları al
        let value = input.value.replace(/\D/g, '');
        
        // Maksimum 11 rakam olsun
        value = value.substring(0, 11);
        
        // İlk rakam 0 değilse başına 0 ekle
        if (value.length > 0 && value[0] !== '0') {
            value = '0' + value;
        }
        
        // Formatı uygula: 0(555) 555 55 55
        let formattedValue = '';
        if (value.length > 0) {
            formattedValue = '0(';
            if (value.length > 1) {
                formattedValue += value.substring(1, 4);
            }
            if (value.length > 4) {
                formattedValue += ') ' + value.substring(4, 7);
            }
            if (value.length > 7) {
                formattedValue += ' ' + value.substring(7, 9);
            }
            if (value.length > 9) {
                formattedValue += ' ' + value.substring(9, 11);
            }
        }
        
        input.value = formattedValue;
    }

    // Event listener'ları ekle
    document.addEventListener('DOMContentLoaded', function() {
        const phoneInputs = document.querySelectorAll('#firmaTelefonu, #cepTelefonu');
        
        phoneInputs.forEach(input => {
            input.addEventListener('input', function() {
                formatPhoneNumber(this);
            });
            
            input.addEventListener('focus', function() {
                if (!this.value) {
                    this.value = '0(';
                }
            });
            
            input.addEventListener('blur', function() {
                if (this.value === '0(') {
                    this.value = '';
                }
            });
            
            // Başlangıçta placeholder'ı ayarla
            input.placeholder = '0(___) ___ __ __';
        });
    });

   

    // Müşteri modalı kapatıldığında ana modalı tekrar aç
    $('#musteriModal').on('hidden.bs.modal', function (e) {
        $('#addDataModal').modal('show');
    });

    // Çarpı butonuna tıklandığında
    $('#musteriModal .btn-close').on('click', function(e) {
        e.preventDefault();
        $('#musteriModal').modal('hide');
        $('#addDataModal').modal('show');
    });

    // ESC tuşu ile kapatıldığında
    $(document).on('keydown', function(e) {
        if (e.key === "Escape" && $('#musteriModal').hasClass('show')) {
            $('#musteriModal').modal('hide');
            $('#addDataModal').modal('show');
        }
    });