const jobseekerTick = document.getElementById("tick-jobseeker");
const employerTick = document.getElementById("tick-employer");

const jobseekerDetails = document.getElementById("jobseeker-bullet");
const employerDetails = document.getElementById("employer-bullet");

const jobseekerAccInfo = document.getElementById("jobseeker-acc-info-form");
const employerAccInfo = document.getElementById("employer-acc-info-form");

const options = document.querySelectorAll('input[name="AccountType"]');

options.forEach(function (option) {
    option.addEventListener("change", showCorrectAccDetails);
});

function showCorrectAccDetails() {
    if (document.getElementById("jobseeker-option").checked) {
        jobseekerTick.style.display = "block";
        employerTick.style.display = "none";

        if (window.location.pathname === "/signup") {
            jobseekerDetails.style.display = "block";
            employerDetails.style.display = "none";

            jobseekerAccInfo.style.display = "block";
            employerAccInfo.style.display = "none";
        }
    }
    else {
        employerTick.style.display = "block";
        jobseekerTick.style.display = "none";

        if (window.location.pathname === "/signup") {
            employerDetails.style.display = "block";
            jobseekerDetails.style.display = "none";

            employerAccInfo.style.display = "block";
            jobseekerAccInfo.style.display = "none";
        }
    }
}

if (window.location.pathname == '/signup' || window.location.pathname == '/login') {
    document.getElementById("jobseeker-option").checked = true;
    showCorrectAccDetails();
}

// Show and hide password

const passwordInput = document.getElementById("password-input");
const showPasswordButton = document.getElementById("pass-eye-button");
const hideIcon = document.getElementById("svg-hide");
const showIcon = document.getElementById("svg-show");


if (showPasswordButton) {
    let passwordVisible = false;
    hideIcon.style.display = "block";
    showIcon.style.display = "none";

    showPasswordButton.addEventListener("click", function () {
        if (passwordVisible) {
            passwordVisible = false;
            passwordInput.type = "password";
            hideIcon.style.display = "block";
            showIcon.style.display = "none";
        }
        else {
            passwordVisible = true;
            passwordInput.type = "text";
            hideIcon.style.display = "none";
            showIcon.style.display = "block";
        }
    });
}

// Navigate between form steps and update the form progress bar.

const navigateToFormStep = (stepNumber) => {
    // Hide all form steps.

    document.querySelectorAll(".form-step").forEach((formStepElement) => {
        formStepElement.classList.add("d-none");
    });

    // Mark all form steps as unfinished.
    document.querySelectorAll(".form-stepper-list").forEach((formStepHeader) => {
        formStepHeader.classList.add("form-stepper-unfinished");
        formStepHeader.classList.remove("form-stepper-active", "form-stepper-completed");
    });

    document.querySelector("#step-" + stepNumber).classList.remove("d-none");
    const formStep = document.querySelector('li[step="' + stepNumber + '"]');

    // Mark the current form step as active.
    formStep.classList.remove("form-stepper-unfinished", "form-stepper-completed");
    formStep.classList.add("form-stepper-active");

    for (let index = 0; index < stepNumber; index++) {
        const formStep = document.querySelector('li[step="' + index + '"]');
        if (formStep) {

            // Mark the form step as completed.
            formStep.classList.remove("form-stepper-unfinished", "form-stepper-active");
            formStep.classList.add("form-stepper-completed");
        }
    }
};

// Check if all visible inputs are valid before navigating to the target form step
// Disable the "Continue" button if any input is invalid
// Uses JQuery client-side validation lib

if (window.location.pathname == '/signup' || window.location.pathname == '/login') {
    $('.form-navigation-button').click(function () {
        const stepNumber = parseInt($(this).attr('step_number'));

        if (!$(this).hasClass('back-button')) {
            let isValid = true;

            $('input:visible').each(function () {
                if (!$(this).valid()) {
                    isValid = false;
                }
            });

            if (!isValid) {
                $('.form-navigation-button.continue').prop('disabled', true);
                return;
            }
        }
        navigateToFormStep(stepNumber);
    });
}

// Toggle visibility of salary amount containers

if (window.location.pathname == '/post-job' || window.location.pathname == '/edit-job') {
    const salaryTypeSelect = document.querySelector('[name="Job.Salary.Type"]');
    const exactAmountContainer = document.querySelector('.exact-amount-container');
    const minAmountContainer = document.querySelector('.min-amount-container');
    const maxAmountContainer = document.querySelector('.max-amount-container');

    const exactAmountInput = document.getElementById('exact-amount-input');
    const minAmountInput = document.getElementById('min-amount-input');
    const maxAmountInput = document.getElementById('max-amount-input');

    if (salaryTypeSelect.selectedIndex == 1) {
        exactAmountContainer.style.display = 'none';
        minAmountContainer.style.display = 'flex';
        maxAmountContainer.style.display = 'flex';
        exactAmountInput.value = "";
    }

    salaryTypeSelect.addEventListener('change', (event) => {
        if (event.target.value === '0') {
            ChangeToExactAmount();
        } else if (event.target.value === '1') {
            ChangeToRange();
        }
    });

    function ChangeToExactAmount() {
        exactAmountContainer.style.display = 'flex';
        minAmountContainer.style.display = 'none';
        maxAmountContainer.style.display = 'none';
        minAmountInput.value = "";
        maxAmountInput.value = "";
    }

    function ChangeToRange() {
        exactAmountContainer.style.display = 'none';
        minAmountContainer.style.display = 'flex';
        maxAmountContainer.style.display = 'flex';
        exactAmountInput.value = "";
    }
}

// Toggle visibility of work arrangement info messages

if (window.location.pathname == '/post-job' || window.location.pathname == '/edit-job') {
    const workArrangementSelect = document.querySelector('[name="Job.WorkArrangement"]');

    const onSiteInfo = document.getElementById('on-site-info');
    const remoteInfo = document.getElementById('remote-info');
    const hybridInfo = document.getElementById('hybrid-info');

    workArrangementSelect.addEventListener('change', (event) => {
        if (event.target.value == '0') {
            onSiteInfo.style.display = 'inline-block';
            remoteInfo.style.display = 'none';
            hybridInfo.style.display = 'none';
        }
        else if (event.target.value == '1') {
            onSiteInfo.style.display = 'none';
            remoteInfo.style.display = 'inline-block';
            hybridInfo.style.display = 'none';
        }
        else {
            onSiteInfo.style.display = 'none';
            remoteInfo.style.display = 'none';
            hybridInfo.style.display = 'inline-block';
        }
    })
}

// Save job button hover effects

const button = document.querySelector('.save-job-button');

if (button) {
    const svg = button.querySelector('svg');

    // Original path data
    const originalPathData = svg.querySelector('path').getAttribute('d');

    // New path data
    const newPathData = 'M2 2v13.5a.5.5 0 0 0 .74.439L8 13.069l5.26 2.87A.5.5 0 0 0 14 15.5V2a2 2 0 0 0-2-2H4a2 2 0 0 0-2 2z';

    // "bi-bookmark-x" svg
    const newSvg = '<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-bookmark-x" viewBox="0 0 16 16"><path fill-rule="evenodd" d="M6.146 5.146a.5.5 0 0 1 .708 0L8 6.293l1.146-1.147a.5.5 0 1 1 .708.708L8.707 7l1.147 1.146a.5.5 0 0 1-.708.708L8 7.707 6.854 8.854a.5.5 0 1 1-.708-.708L7.293 7 6.146 5.854a.5.5 0 0 1 0-.708z"/><path d="M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z"/></svg>';

    button.addEventListener('mouseenter', () => {
        if (button.classList.contains('saved')) {
            // Set the new "bi-bookmark-x" SVG
            svg.innerHTML = newSvg;
        }
        else {
            // Set the new path data
            svg.querySelector('path').setAttribute('d', newPathData);
        }
    });

    button.addEventListener('mouseleave', () => {
        if (button.classList.contains('saved')) {
            // Set the original SVG
            svg.querySelector('path').setAttribute('d', originalPathData);
        }
        else {
            // Set the original path data
            svg.querySelector('path').setAttribute('d', originalPathData);
        }
    });
}

// Toggle update status form

if (window.location.pathname == '/job-dashboard') {
    document.addEventListener("DOMContentLoaded", function () {
        const toggleStatusButtons = document.querySelectorAll(".toggle-status-form-button");
        toggleStatusButtons.forEach(function (button) {
            const formId = button.dataset.formId;
            const form = document.getElementById(formId);
            form.classList.toggle("hidden");
            button.addEventListener("click", function () {
                form.classList.toggle("hidden");
            });
        });
    });
}

function addToggleMenuListeners(toggleElement, menuElement) {
    toggleElement.addEventListener("click", function (event) {
        event.stopPropagation();
        toggleMenu(menuElement);
    });

    document.addEventListener("click", function (event) {
        const target = event.target;
        if (target !== toggleElement && !toggleElement.contains(target) && target !== menuElement && !menuElement.contains(target)) {
            menuElement.style.display = "none";
        }
    });
}

function toggleMenu(menuElement) {
    const computedStyle = window.getComputedStyle(menuElement);
    if (computedStyle.display === "none") {
        menuElement.style.display = "flex";
    } else {
        menuElement.style.display = "none";
    }
}

const navProfileToggle = document.getElementById("nav-profile-toggle");
const profileMenu = document.querySelector(".profile-menu");

if (navProfileToggle && window.getComputedStyle(navProfileToggle).display !== "none") {
    addToggleMenuListeners(navProfileToggle, profileMenu);
}

const hamburgerMenuToggle = document.getElementById("hamburger-menu");
const hamburgerMenu = document.querySelector(".hamburger-menu-container");

addToggleMenuListeners(hamburgerMenuToggle, hamburgerMenu);


function closeSuccessMessage() {
    var successMessage = document.querySelector('.success-message');
    successMessage.style.display = 'none';
}