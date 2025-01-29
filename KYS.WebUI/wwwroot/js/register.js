document.addEventListener("DOMContentLoaded", function () {
    const registerModal = document.getElementById('registerModal');
    const modalInstance = new bootstrap.Modal(registerModal);

    if (registerModal) {
        // Modal açıldığında
        registerModal.addEventListener('shown.bs.modal', () => {
            registerModal.removeAttribute('aria-hidden'); // Modal açık olduğunda erişilebilir olmalı
        });

        // Modal kapatıldığında
        registerModal.addEventListener('hidden.bs.modal', () => {
            registerModal.setAttribute('aria-hidden', 'true'); // Modal kapalı olduğunda gizlenmeli
        });
    }
});
