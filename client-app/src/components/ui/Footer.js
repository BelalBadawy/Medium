import React from 'react'

export const Footer = () => {
    return (
        <footer className="footer">
            <div className="container">

                <div className="row">
                    <div className="col-lg-12">
                        <div className="text-center">
                            <a className="pb-2 display-4 mb-0 d-inline-block text-dark" href="index.html"><i
                                className="icofont-deer-head"></i></a>
                            <h4 className="font-weight-bold">BUCKZO</h4>

                            <ul className="list-inline social-circle margin-t-30">
                                <li className="list-inline-item"><a href=""> <i className="icofont-envato"></i> </a></li>
                                <li className="list-inline-item"><a href=""> <i className="icofont-facebook"></i> </a></li>
                                <li className="list-inline-item"><a href=""> <i className="icofont-skype"></i> </a></li>
                                <li className="list-inline-item"><a href=""> <i className="icofont-twitter"></i> </a></li>
                                <li className="list-inline-item"><a href=""> <i className="icofont-whatsapp"></i> </a></li>
                            </ul>

                            <p className="text-muted m-b-0 copyright-txt"> © <script>document.write(new Date().getFullYear())</script> Buckzo. By MyraStudio</p>

                        </div>
                    </div>
                </div>
                {/* <!--  end row --> */}

            </div>
        </footer>
    )
}
