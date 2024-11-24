import React, { useState, useEffect } from "react";
import { Button, Table } from "semantic-ui-react";
import axios from "axios";
import "./Read.css"

export default function JobRead() {
    const [JobData, setJobData] = useState([]);
    
    useEffect(() => {
        axios.get(`${process.env.REACT_APP_ALSPEC_API_URL}/Job`)
            .then((response) => {
                setJobData(response.data.$values);
            }, (error) => {
                console.log(error);
            })
    }, []);

    return (
        <div className="jobPage">
            <h1><span className="green">Al</span>spec <span className="green">Pr</span>oducts</h1>
            <div className="addButton"><Button positive>Add Job</Button></div>
            <Table celled>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell width={1}>Job ID</Table.HeaderCell>
                        <Table.HeaderCell width={1}>Title</Table.HeaderCell>
                        <Table.HeaderCell width={1}>Description</Table.HeaderCell>
                    </Table.Row>
                </Table.Header>
                <Table.Body>
                    {JobData.map((job, index) => {
                        return (
                            <>
                            <Table.Row key={job.Id}>
                                <Table.Cell>{job.Id}</Table.Cell>
                                <Table.Cell>{job.Title}</Table.Cell>
                                <Table.Cell>{job.Description}</Table.Cell>
                            </Table.Row>
                            {job.SubItems.$values.map((subItem, subIndex) => { 
                                return(
                                    <Table.Row key={subItem.ItemId}>
                                        {subIndex === 0 ? <Table.Cell rowSpan={job.SubItems.$values.length}></Table.Cell> : null}
                                        <Table.Cell colSpan={2} className={
                                            subItem.Status === "Pending" ? "pending" :
                                            subItem.Status === "In Progress" ? "inprogress" : "completed"}>
                                            <p>Item ID: {subItem.ItemId}</p>
                                            <p>Title: {subItem.Title}</p>
                                            <p>Description: {subItem.Description}</p>
                                            <p>Status: {subItem.Status}</p>
                                        </Table.Cell>
                                    </Table.Row>
                                );
                            })}
                            </>
                        );
                    })}
                </Table.Body>
            </Table>
        </div>
    )
}