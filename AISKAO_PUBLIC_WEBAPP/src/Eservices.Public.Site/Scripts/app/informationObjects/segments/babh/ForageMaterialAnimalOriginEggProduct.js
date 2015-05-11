﻿define('babh/ForageMaterialAnimalOriginEggProduct',
    ['ko', 'Utils',
    'GlobalParameters',
    'Enums',
    'babh/ForageFormBulkOrPackeds'],
    function (ko, Utils,
        gp,
        Enums,
        ForageFormBulkOrPackeds) {

        var ForageMaterialAnimalOriginEggProduct = function () {
            this._settings = {};
            this._settings.sectionTitle = 'Данни за фуражи за транспортиране по форма - фуражни суровини от растителен произход';
            this._settings.xmlns = 'http://ereg.egov.bg/segment/R-1311';
            this._settings.options = {
                xmlns: this._settings.xmlns
            };


            this.forageFormBulkOrPackeds = ko.observable(new ForageFormBulkOrPackeds());
        }

        ForageMaterialAnimalOriginEggProduct.prototype = function () {
            toJSON = function () {
                return Utils.toJSONForXML(this, this._settings.options);
            };
            return {
                toJSON: toJSON
            }
        }();

        return ForageMaterialAnimalOriginEggProduct;

    });