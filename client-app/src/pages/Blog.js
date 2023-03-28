import React from 'react'
import { LoaderSpinner, SideBar } from "../components/index";

export const Blog = () => {
    return (
        <>
            <section>
                <div className="container">
                    <div className="row">
                        <div className="col-lg-12">
                            <div className="page-title">
                                <div className="row">
                                    <div className="col-lg-9">
                                        <h2>Beautiful Day With Friends In Paris</h2>
                                        <ul className="post-meta">
                                            <li><i className="icofont-ui-calendar"></i> Feb 18, 2020</li>
                                            <li><i className="icofont-tags"></i> <a href="#">Branding</a>, <a href="#">Design</a></li>
                                            <li><i className="icofont-comment"></i> <a href="#">3 Comments</a></li>
                                            <li><i className="icofont-user-alt-5"></i> <a href="#">Admin</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>


            <section className="margin-t-30">
                <div className="container">

                    <div className="row">
                        {/* <!-- Content--> */}
                        <div className="col-lg-8">

                            {/* <!-- Post--> */}
                            <article className="post">

                                <div className="post-preview">
                                    <a href="#"><img src="images/blog/blog-4.jpg" alt="" className="img-fluid rounded" /></a>
                                </div>

                                <div className="blog-detail-description">
                                    <p>Donec eleifend accumsan nibh eu efficitur. Vivamus lacinia ut turpis egestas convallis. Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>

                                    <p>Donec eleifend accumsan nibh eu efficitur. Vivamus lacinia ut turpis egestas convallis. Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>


                                    <blockquote>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore.</blockquote>

                                    <p>Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>

                                    <div className="margin-t-30">
                                        <h5>Tags:</h5>
                                        <div className="tagcloud">
                                            <a href="#">logo</a>
                                            <a href="#">business</a>
                                            <a href="#">agency</a>
                                        </div>
                                    </div>

                                    <div className="page-title">
                                        <h3><span>Comments</span></h3>
                                    </div>

                                    <ul className="media-list ps-0">

                                        <li className="media">
                                            <a className="pull-left pe-3" href="#">
                                                <img className="media-object rounded-circle" src="images/team/team-1.jpg" alt="img" />
                                            </a>

                                            <div className="media-body">
                                                <a href="#" className="text-custom"><i className="icofont-reply"></i>&nbsp; Reply</a>
                                                <h4 className="media-heading">Michelle Durant</h4>
                                                <h6 className="text-muted">Jun 23, 2020, 11:45 am</h6>
                                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
                                            </div>
                                        </li>

                                        <li className="media">
                                            <a className="pull-left pe-3" href="#">
                                                <img className="media-object rounded-circle" src="images/team/team-2.jpg" alt="img" />
                                            </a>

                                            <div className="media-body">
                                                <a href="#" className="text-custom"><i className="icofont-reply"></i>&nbsp; Reply</a>
                                                <h4 className="media-heading">Ronda Otoole</h4>
                                                <h6 className="text-muted">Jun 23, 2020, 11:45 am</h6>
                                                <p>Nulla venenatis. In pede mi, aliquet sit amet, euismod in, auctor ut, ligula. Aliquam dapibus tincidunt metus. Praesent justo dolor, lobortis quis, lobortis dignissim, pulvinar ac, lorem. Vestibulum sed ante.</p>

                                                <div className="media sub_media">
                                                    <a className="pull-left pe-3" href="#">
                                                        <img className="media-object rounded-circle" src="images/team/team-1.jpg" alt="img" />
                                                    </a>
                                                    <div className="media-body">
                                                        <a href="#" className="text-custom"><i className="icofont-reply"></i>&nbsp; Reply</a>
                                                        <h4 className="media-heading">James Whitley</h4>
                                                        <h6 className="text-muted">Jun 23, 2020, 11:45 am</h6>
                                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae.</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </li>

                                        <li className="media">
                                            <a className="pull-left pe-3" href="#">
                                                <img className="media-object rounded-circle" src="images/team/team-3.jpg" alt="" />
                                            </a>
                                            <div className="media-body">
                                                <a href="#" className="text-custom"><i className="icofont-reply"></i>&nbsp; Reply</a>
                                                <h4 className="media-heading">Kimberly Chretien</h4>
                                                <h6 className="text-muted">Jun 23, 2020, 11:45 am</h6>
                                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
                                            </div>
                                        </li>
                                    </ul>

                                </div>

                                <div className="page-title margin-t-50">
                                    <h4><span>Leave a reply</span></h4>
                                </div>

                                <form action="#" method="post" className="margin-t-30">
                                    <div className="row">
                                        <div className="col-lg-6">
                                            <div className="form-group">
                                                <input id="author" className="form-control" placeholder="Name*" name="author" type="text" required="" />
                                            </div>
                                        </div>

                                        <div className="col-lg-6">
                                            <div className="form-group">
                                                <input id="email" className="form-control" placeholder="Email*" name="email" type="text" required="" />
                                            </div>
                                        </div>
                                    </div>
                                    <div className="row">
                                        <div className="col-lg-12">
                                            <div className="form-group">
                                                <input id="subject" className="form-control" placeholder="Website" name="subject" type="text" />
                                            </div>
                                        </div>
                                    </div>

                                    <div className="row">
                                        <div className="col-lg-12">
                                            <div className="form-group">
                                                <textarea id="comment" className="form-control" rows="5" placeholder="Your Message*" name="comment" required=""></textarea>
                                            </div>
                                        </div>
                                    </div>

                                    <div className="row">
                                        <div className="col-lg-12">
                                            <div className="form-group">
                                                <button name="submit" type="submit" id="submit" className="btn btn-dark">Post Comment</button>
                                            </div>
                                        </div>
                                    </div>
                                </form>

                            </article>
                            {/* <!-- Post end--> */}

                        </div>
                        {/* <!-- Content end--> */}


                        {/* <!-- Sidebar--> */}
                        <div className="col-lg-4">
                            <div className="sidebar">
                                <SideBar />
                            </div>
                        </div>
                        {/* <!-- Sidebar end--> */}
                    </div>

                </div> {/* <!-- end container --> */}
            </section>
        </>
    )
}
